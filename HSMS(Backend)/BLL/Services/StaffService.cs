using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class StaffService
    {
        private static IMapper _mapper;

        static StaffService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Staff, StaffDTO>();
                cfg.CreateMap<StaffDTO, Staff>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<StaffDTO> Get()
        {
            var data = DataAccessFactory.StaffData().Get();
            return _mapper.Map<List<StaffDTO>>(data);
        }

        public static StaffDTO Get(int id)
        {
            var data = DataAccessFactory.StaffData().Get(id);
            return _mapper.Map<StaffDTO>(data);
        }

        public static bool Post(StaffDTO staffDTO)
        {
            var staff = _mapper.Map<Staff>(staffDTO);
            return DataAccessFactory.StaffData().Post(staff);
        }

        public static bool Update(StaffDTO staffDTO)
        {
            var staff = _mapper.Map<Staff>(staffDTO);
            return DataAccessFactory.StaffData().Update(staff);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StaffData().Delete(id);
        }
    }
}
