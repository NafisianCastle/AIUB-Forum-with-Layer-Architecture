using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminRepo : IRepository<Admin, int>
    {
        private AIUB_ForumEntities _db;

        public AdminRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Admin obj)
        {
            _db.Admins.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Admin Get(int id)
        {
            return _db.Admins.FirstOrDefault(x => x.AdminId == id);
        }

        public List<Admin> Get()
        {
            return _db.Admins.ToList();
        }

        public bool Edit(Admin obj)
        {
            var p = _db.Admins.FirstOrDefault(en => en.AdminId == obj.AdminId);
            _db.Entry(p).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Admins.FirstOrDefault(e => e.AdminId == id);
            if (c == null)
            {
                return false;
            }

            _db.Admins.Remove(c);
            return true;
        }

       
    }
}
