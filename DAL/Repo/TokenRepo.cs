using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class TokenRepo : IRepository<Token, string>, IAuth<Token>
    {
        private readonly AIUB_ForumEntities _db;
        public TokenRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Token obj)
        {
            _db.Tokens.Add(obj);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;

        }

        public Token Authenticate(string uname, string pass)
        {
            var data = _db.Users.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
            if (data == null)
            {
                return null;
            }

            var token = new Token
            {
                Tkey = Guid.NewGuid().ToString(),
                CreationDate = DateTime.Now,
                UserId = data.UserId,
                ExpireDate = null
            };
            return this.Add(token) ? token : null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string tKey)
        {
            return _db.Tokens.FirstOrDefault(e => e.Tkey.Equals(tKey));
        }

        public List<Token> Get()
        {
            return _db.Tokens.ToList();
        }
    }
}