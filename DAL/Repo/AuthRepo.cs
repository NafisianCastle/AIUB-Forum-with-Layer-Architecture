using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        private readonly AIUB_ForumEntities _db;
        public AuthRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Token obj)
        {
            _db.Tokens.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Token Authenticate(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
            if (user == null) return null;
            var token = new Token
            {
                Tkey = Guid.NewGuid().ToString(),
                CreationDate = DateTime.Now,
                ExpireDate = null,
                UserId = user.UserId
            };
            return Add(token) ? token : null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            return _db.Tokens.FirstOrDefault(x => x.Tkey.Equals(id));
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }
    }
}