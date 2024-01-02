using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class SchoolInfoService
    {
        private static IMapper _mapper;

        static SchoolInfoService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SchoolInfo, SchoolInfoDTO>();
                cfg.CreateMap<SchoolInfoDTO, SchoolInfo>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<SchoolInfoDTO> Get()
        {
            var data = DataAccessFactory.SchoolInfoData().Get();
            return _mapper.Map<List<SchoolInfoDTO>>(data);
        }

        public static SchoolInfoDTO Get(int id)
        {
            var data = DataAccessFactory.SchoolInfoData().Get(id);
            return _mapper.Map<SchoolInfoDTO>(data);
        }

        public static bool Post(SchoolInfoDTO schoolInfoDTO)
        {
            var schoolInfo = _mapper.Map<SchoolInfo>(schoolInfoDTO);
            return DataAccessFactory.SchoolInfoData().Post(schoolInfo);
        }

        public static bool Update(SchoolInfoDTO schoolInfoDTO)
        {
            var schoolInfo = _mapper.Map<SchoolInfo>(schoolInfoDTO);
            return DataAccessFactory.SchoolInfoData().Update(schoolInfo);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SchoolInfoData().Delete(id);
        }
    }
}
