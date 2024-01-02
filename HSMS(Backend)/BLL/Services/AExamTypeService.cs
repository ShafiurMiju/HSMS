using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AExamTypeService
    {
        private static IMapper _mapper;

        static AExamTypeService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ExamType, ExamTypeDTO>();
                cfg.CreateMap<ExamTypeDTO, ExamType>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<ExamTypeDTO> Get()
        {
            var data = DataAccessFactory.ExamTypeData().Get();
            return _mapper.Map<List<ExamTypeDTO>>(data);
        }

        public static ExamTypeDTO Get(int id)
        {
            var data = DataAccessFactory.ExamTypeData().Get(id);
            return _mapper.Map<ExamTypeDTO>(data);
        }

        public static bool Post(ExamTypeDTO examTypeDTO)
        {
            var examType = _mapper.Map<ExamType>(examTypeDTO);
            return DataAccessFactory.ExamTypeData().Post(examType);
        }

        public static bool Update(ExamTypeDTO examTypeDTO)
        {
            var examType = _mapper.Map<ExamType>(examTypeDTO);
            return DataAccessFactory.ExamTypeData().Update(examType);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ExamTypeData().Delete(id);
        }
    }
}
