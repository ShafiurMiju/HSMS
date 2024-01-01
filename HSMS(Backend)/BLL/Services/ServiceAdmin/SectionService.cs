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
    public class SectionService
    {
        public static List<SectionDTO> Get()
        {
            var data = DataAccessFactory.SectionData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Section, SectionDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<SectionDTO>>(data);
        }

        public static SectionDTO Get(int id)
        {
            var data = DataAccessFactory.SectionData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Section, SectionDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<SectionDTO>(data);
        }

        public static bool Post(SectionDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SectionDTO, Section>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Section>(c);

            return DataAccessFactory.SectionData().Post(data);
        }

        public static bool Update(SectionDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SectionDTO, Section>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Section>(c);

            return DataAccessFactory.SectionData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SectionData().Delete(id);
        }

        public static SectionDTO GetSectionStudent(int id)
        {
            var data = DataAccessFactory.SectionData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Section, SectionStudentDTO>();
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<SectionStudentDTO>(data);
        }
    }
}
