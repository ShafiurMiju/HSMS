using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class GradeService
    {
        private static IMapper _mapper;

        static GradeService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Grade, GradeDTO>();
                cfg.CreateMap<GradeDTO, Grade>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<GradeDTO> Get()
        {
            var data = DataAccessFactory.GradeData().Get();
            return _mapper.Map<List<GradeDTO>>(data);
        }

        public static GradeDTO Get(int id)
        {
            var data = DataAccessFactory.GradeData().Get(id);
            return _mapper.Map<GradeDTO>(data);
        }

        public static bool Post(GradeDTO gradeDTO)
        {
            var grade = _mapper.Map<Grade>(gradeDTO);
            return DataAccessFactory.GradeData().Post(grade);
        }

        public static bool Update(GradeDTO gradeDTO)
        {
            var grade = _mapper.Map<Grade>(gradeDTO);
            return DataAccessFactory.GradeData().Update(grade);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.GradeData().Delete(id);
        }
    }
}
