using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services.ServiceAdmin
{
    public class STeacherStudentService
    {
        public static List<TeacherStudentDTO> Get()
        {
            var data = DataAccessFactory.TeacherStudentChatsData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherStudentChat, TeacherStudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<TeacherStudentDTO>>(data);
        }

        public static TeacherStudentDTO Get(int id)
        {
            var data = DataAccessFactory.TeacherStudentChatsData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherStudentChat, TeacherStudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<TeacherStudentDTO>(data);
        }

        public static bool Post(TeacherStudentDTO d)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherStudentDTO, TeacherStudentChat>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<TeacherStudentChat>(d);

            return DataAccessFactory.TeacherStudentChatsData().Post(data);
        }

        public static bool Update(TeacherStudentDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherStudentDTO, TeacherStudentChat>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<TeacherStudentChat>(c);

            return DataAccessFactory.TeacherStudentChatsData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TeacherStudentChatsData().Delete(id);
        }


    }
}