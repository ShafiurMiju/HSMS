using System.Collections.Generic;
using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;

namespace BLL.Services
{
    public class ExamService
    {
        private static IMapper _mapper;

        static ExamService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Exam, ExamDTO>();
                cfg.CreateMap<ExamDTO, Exam>();
                cfg.CreateMap<Exam, ExamTypeClassDTO>();
                cfg.CreateMap<ExamType, ExamTypeDTO>();
                cfg.CreateMap<Class, ClassDTO>();
            });

            _mapper = new Mapper(config);
        }

        public static List<ExamTypeClassDTO> Get()
        {
            var data = DataAccessFactory.ExamData().Get();
            return _mapper.Map<List<ExamTypeClassDTO>>(data);
        }

        public static ExamDTO Get(int id)
        {
            var data = DataAccessFactory.ExamData().Get(id);
            return _mapper.Map<ExamTypeClassDTO>(data);
        }

        public static bool Post(ExamDTO exam)
        {
            var data = _mapper.Map<Exam>(exam);
            return DataAccessFactory.ExamData().Post(data);
        }

        public static bool Update(ExamDTO exam)
        {
            var data = _mapper.Map<Exam>(exam);
            return DataAccessFactory.ExamData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ExamData().Delete(id);
        }
    }
}
