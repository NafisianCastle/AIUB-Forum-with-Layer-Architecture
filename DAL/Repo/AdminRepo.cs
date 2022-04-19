using System;
using DAL.Database;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;

namespace DAL.Repo
{
    public class AdminRepo : IRepository<User,int>
    {
        private readonly AIUB_ForumEntities _db;

        public AdminRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(User obj)
        {
            var p = _db.Users.FirstOrDefault(en => en.UserId == obj.UserId);
            obj.UserType = "Admin";
            _db.Entry(p).CurrentValues.SetValues(obj);
            _db.SaveChanges();
            var admin =new Admin
            {
                UserId = obj.UserId
            };
            _db.Admins.Add(admin);
            return _db.SaveChanges() != 0;
        }

        public bool Edit(User u)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}
