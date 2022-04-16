using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        AIUB_ForumEntities db;
        public AuthRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Token obj)
        {
            db.Tokens.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Token Authenticate(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
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
            return db.Tokens.FirstOrDefault(x => x.Tkey.Equals(id));
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }
    }
}