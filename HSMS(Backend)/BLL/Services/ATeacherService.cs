using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services.ServiceAdmin
{
    public class ATeacherService
    {
        private static IMapper _mapper;

        static ATeacherService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teacher, TeacherDTO>();
                cfg.CreateMap<TeacherDTO, Teacher>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.ATeacherData().Get();
            return _mapper.Map<List<TeacherDTO>>(data);
        }

        public static TeacherDTO Get(int id)
        {
            var data = DataAccessFactory.ATeacherData().Get(id);
            return _mapper.Map<TeacherDTO>(data);
        }

        public static object Post(TeacherDTO c)
        {
            if (DataAccessFactory.TSearchData().Search(c.Email))
            {
                return new { Message = "Email Exist" };
            }
            var data = _mapper.Map<Teacher>(c);

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(data.Password) == true)
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(data.Password, salt);
                data.Password = hashedPassword;
            }
            else
            {
                return new { Message = "At least one lowercase letter, one uppercase letter, one digit, one special character && Minimum length of 8 characters" };
            }

            return DataAccessFactory.ATeacherData().Post(data);

        }

        public static bool Update(TeacherDTO teacherDTO)
        {
            var teacher = _mapper.Map<Teacher>(teacherDTO);
            return DataAccessFactory.ATeacherData().Update(teacher);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ATeacherData().Delete(id);
        }
    }
}
