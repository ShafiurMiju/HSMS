using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DAL.EF.Models.Admin, AdminDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<AdminDTO>(data);
        }
    }
}
