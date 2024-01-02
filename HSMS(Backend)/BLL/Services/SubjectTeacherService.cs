using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class SubjectTeacherService
    {
        private static IMapper _mapper;

        static SubjectTeacherService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SubjectTeacher, SubjectTeacherDTO>();
                cfg.CreateMap<SubjectTeacherDTO, SubjectTeacher>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<SubjectTeacherDTO> Get()
        {
            var data = DataAccessFactory.SubjectTeacherData().Get();
            return _mapper.Map<List<SubjectTeacherDTO>>(data);
        }

        public static SubjectTeacherDTO Get(int id)
        {
            var data = DataAccessFactory.SubjectTeacherData().Get(id);
            return _mapper.Map<SubjectTeacherDTO>(data);
        }

        public static bool Post(SubjectTeacherDTO subjectTeacherDTO)
        {
            var subjectTeacher = _mapper.Map<SubjectTeacher>(subjectTeacherDTO);
            return DataAccessFactory.SubjectTeacherData().Post(subjectTeacher);
        }

        public static bool Update(SubjectTeacherDTO subjectTeacherDTO)
        {
            var subjectTeacher = _mapper.Map<SubjectTeacher>(subjectTeacherDTO);
            return DataAccessFactory.SubjectTeacherData().Update(subjectTeacher);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SubjectTeacherData().Delete(id);
        }
    }
}
