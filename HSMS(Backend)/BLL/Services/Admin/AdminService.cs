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
        public static bool Login(string Email, string Password)
        {
            return DataAccessFactory.AuthData().Auth(Email, Password);           
        }

        public static List<AdminDTO> Get()
        {

            var data = DataAccessFactory.AdminData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin,AdminDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<AdminDTO>>(data);
        }
    }
}
