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
        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.ATeacherData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teacher, TeacherDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<TeacherDTO>>(data);
        }

        public static TeacherDTO Get(int id)
        {
            var data = DataAccessFactory.ATeacherData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teacher, TeacherDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<TeacherDTO>(data);
        }

        public static object Post(TeacherDTO c)
        {


            var email = c.Email;

            var exemail = DataAccessFactory.TSearchData().Search(email);


            if (!exemail)
            {
                var confiq = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TeacherDTO, Teacher>();
                });

                var mapper = new Mapper(confiq);

                var data = mapper.Map<Teacher>(c);

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

            else
            {
                return new { Message = "Email Exist" };
            }


        }

        public static bool Update(TeacherDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherDTO, Teacher>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Teacher>(c);

            return DataAccessFactory.ATeacherData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ATeacherData().Delete(id);
        }
    }
}
