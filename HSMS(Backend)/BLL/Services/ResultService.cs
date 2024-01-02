using System.Collections.Generic;
using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System.Linq;

namespace BLL.Services
{
    public class ResultService
    {
        private static IMapper _mapper;

        static ResultService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Result, ResultDTO>();
                cfg.CreateMap<ResultDTO, Result>();
                cfg.CreateMap<Result, StudentResultsDTO>();
                cfg.CreateMap<Student, StudentDTO>();

            });

            _mapper = new Mapper(config);
        }

        public static List<ResultDTO> Get()
        {
            var data = DataAccessFactory.ResultData().Get();
            return _mapper.Map<List<ResultDTO>>(data);
        }

        public static ResultDTO Get(int id)
        {
            var data = DataAccessFactory.ResultData().Get(id);
            return _mapper.Map<ResultDTO>(data);
        }

        public static bool Post(ResultDTO result)
        {
            var data = _mapper.Map<Result>(result);
            return DataAccessFactory.ResultData().Post(data);
        }

        public static bool Update(ResultDTO result)
        {
            var data = _mapper.Map<Result>(result);
            return DataAccessFactory.ResultData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ResultData().Delete(id);
        }

        public static List<StudentResultsDTO> GetResultsByStudent(int studentId)
        {
            var data = DataAccessFactory.StudentResultData().GetResultsByStudent(studentId);
            return _mapper.Map<List<StudentResultsDTO>>(data);
        }

        public static object CalculateAverageMarks(int studentId)
        {
            var results = DataAccessFactory.StudentResultData().GetResultsByStudent(studentId);

            if (results.Count > 0)
            {
                double totalMarks = results.Sum(r => r.MarksObtained);
                double avg = totalMarks / results.Count;
                return new { Average = avg };
            }

            return null;
        }
    }
}
