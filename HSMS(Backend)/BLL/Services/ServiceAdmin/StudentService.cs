using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> Get()
        {
            var data = DataAccessFactory.StudentData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<StudentDTO>>(data);
        }

        public static StudentDTO Get(int id)
        {
            var data = DataAccessFactory.StudentData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<StudentDTO>(data);
        }

        public static bool Post(StudentDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Student>(c);

            return DataAccessFactory.StudentData().Post(data);
        }

        public static bool Update(StudentDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Student>(c);

            return DataAccessFactory.StudentData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentData().Delete(id);
        }
    }
}
