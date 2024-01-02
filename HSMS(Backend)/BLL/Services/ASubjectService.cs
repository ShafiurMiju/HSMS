using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ASubjectService
    {
        private static IMapper _mapper;

        static ASubjectService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Subject, SubjectDTO>();
                cfg.CreateMap<SubjectDTO, Subject>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<SubjectDTO> Get()
        {
            var data = DataAccessFactory.SubjectData().Get();
            return _mapper.Map<List<SubjectDTO>>(data);
        }

        public static SubjectDTO Get(int id)
        {
            var data = DataAccessFactory.SubjectData().Get(id);
            return _mapper.Map<SubjectDTO>(data);
        }

        public static bool Post(SubjectDTO SubjectDTO)
        {
            var Subject = _mapper.Map<Subject>(SubjectDTO);
            return DataAccessFactory.SubjectData().Post(Subject);
        }

        public static bool Update(SubjectDTO SubjectDTO)
        {
            var classSubject = _mapper.Map<Subject>(SubjectDTO);
            return DataAccessFactory.SubjectData().Update(classSubject);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SubjectData().Delete(id);
        }
    }
}
