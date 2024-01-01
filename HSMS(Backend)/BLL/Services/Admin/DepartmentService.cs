using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        public static List<DepartmentDTO> Get()
        {
            var data = DataAccessFactory.DepartmentData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Department, DepartmentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<DepartmentDTO>>(data);
        }

        public static DepartmentDTO Get(int id)
        {
            var data = DataAccessFactory.DepartmentData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Department, DepartmentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<DepartmentDTO>(data);
        }

        public static bool Post(DepartmentDTO d)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DepartmentDTO, Department>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Department>(d);

            return DataAccessFactory.DepartmentData().Post(data);
        }

        public static bool Update(DepartmentDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DepartmentDTO, Department>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Department>(c);

            return DataAccessFactory.DepartmentData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.DepartmentData().Delete(id);
        }

        public static DepartmentDTO GetDepartmentTeacher(int id)
        {
            var data = DataAccessFactory.DepartmentData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Department, DepartmentTeacherDTO>();
                cfg.CreateMap<Teacher, TeacherDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<DepartmentTeacherDTO>(data);
        }
    }
}
