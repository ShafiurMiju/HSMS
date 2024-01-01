using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Admin
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string Email, string Password)
        {
            var res = DataAccessFactory.AuthData().Auth(Email, Password);

            if (res == true)
            {
                var admin = DataAccessFactory.AdminData().Get(Email);

                var token = new Token();
                token.AdminID = admin.ID;
                token.TokenKey = Guid.NewGuid().ToString();
                token.LoggedTime= DateTime.Now;
                token.ExpiredTime= DateTime.Now.AddMinutes(20);

                var ret = DataAccessFactory.TokenData().Post(token);

                if(ret !=null)
                {
                    var confiq = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Token, TokenDTO>();
                    });

                    var mapper = new Mapper(confiq);

                    return mapper.Map<TokenDTO>(ret);
                }
            }

            return null;
        }

        public static bool IsTokenValid(string tkey)
        {
            var ex = DataAccessFactory.TokenData().Get(tkey);
            if(ex != null)
            {
                return true;
            }
            return false;
        }

        public static bool Logout(string tkey)
        {
            var ex = DataAccessFactory.TokenData().Get(tkey);

            ex.ExpiredTime = DateTime.Now;

            if(DataAccessFactory.TokenData().Update(ex) != null)
            {
                return true;
            }
            return false;

        }
    }
}
