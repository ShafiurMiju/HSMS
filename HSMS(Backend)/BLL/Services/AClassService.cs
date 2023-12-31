﻿using AutoMapper;
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
        private static IMapper _mapper;
        static AClassService() {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Class, ClassDTO>();
                cfg.CreateMap<ClassDTO, Class>();
                cfg.CreateMap<Class, ClassStudentDTO>();
                cfg.CreateMap<Student, StudentDTO>();
            });

            _mapper = new Mapper(confiq);
        }

        public static List<ClassDTO> Get()
        {
            var data = DataAccessFactory.ClassData().Get();
            return _mapper.Map<List<ClassDTO>>(data);
        }

        public static ClassDTO Get(int id)
        {
            var data = DataAccessFactory.ClassData().Get(id);
            return _mapper.Map<ClassDTO>(data);
        }

        public static bool Post(ClassDTO c)
        {
            var data = _mapper.Map<Class>(c);
            return DataAccessFactory.ClassData().Post(data);
        }

        public static bool Update(ClassDTO c)
        {
            var data = _mapper.Map<Class>(c);
            return DataAccessFactory.ClassData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ClassData().Delete(id);
        }

        public static ClassDTO GetClassStudent(int id)
        {
            var data = DataAccessFactory.ClassData().Get(id);
            return _mapper.Map<ClassStudentDTO>(data);
        }
    }
}
