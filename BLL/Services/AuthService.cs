using BLL.Entities;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenModel Authenticate(string uname,string pass)
        {
            var token = DataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
            //create tokenModel and map to token model
            return token != null ? new TokenModel() {Tkey=token.Tkey,CreationDate=token.CreationDate,ExpireDate=token.ExpireDate } : null;
        }
        public static bool ValidateToken(string key)
        {
            var token = DataAccessFactory.TokenDataAccess().Get(key);
            return token != null && token.ExpireDate == null;
        }
    }
}