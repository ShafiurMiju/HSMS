using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(t=>t.TokenKey.Equals(id) && t.ExpiredTime >=  DateTime.Now);
        }

        public Token Post(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Token Update(Token obj)
        {
            var Token = Get(obj.TokenKey);
            db.Entry(Token).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;    
        }
    }
}
