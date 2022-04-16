using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    public class TokenRepo : IRepository<Token, string>
    {
        readonly AIUB_ForumEntities _db;
        public TokenRepo(AIUB_ForumEntities db) {
            this._db = db;
        }
        public bool Add(Token e)
        {
            _db.Tokens.Add(e);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(string token)
        {
            _db.Tokens.Remove(_db.Tokens.FirstOrDefault(e => e.Tkey.Equals(token)) ?? throw new InvalidOperationException());
            return _db.SaveChanges() != 0;
        }

        public bool Edit(Token e)
        {
            var token = _db.Tokens.FirstOrDefault(en => en.Tkey.Equals(e.Tkey));
            _db.Entry(token).CurrentValues.SetValues(e);
            return _db.SaveChanges() != 0;

        }

        public List<Token> Get()
        {
            return _db.Tokens.ToList();
        }

        public Token Get(string token)
        {
            return _db.Tokens.FirstOrDefault(e => e.Tkey.Equals(token));
        }
    }
}