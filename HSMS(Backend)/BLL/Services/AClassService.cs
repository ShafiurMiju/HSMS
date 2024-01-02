using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AClassService
    {
        public static List<ClassDTO> Get()
        {
            var data = DataAccessFactory.ClassData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Class, ClassDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<ClassDTO>>(data);
        }

        public static ClassDTO Get(int id)
        {
            var data = DataAccessFactory.ClassData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Class, ClassDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<ClassDTO>(data);
        }

        public static bool Post(ClassDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassDTO, Class>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Class>(c);

            return DataAccessFactory.ClassData().Post(data);
        }

        public static bool Update(ClassDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassDTO, Class>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Class>(c);

            return DataAccessFactory.ClassData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ClassData().Delete(id);
        }

        public static ClassDTO GetClassStudent(int id)
        {
            var data = DataAccessFactory.ClassData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Class, ClassStudentDTO>();
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<ClassStudentDTO>(data);
        }
    }
}
