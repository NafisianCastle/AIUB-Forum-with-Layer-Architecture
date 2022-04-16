using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class ModeratorRepo : IRepository<Moderator, int>
    {
        private AIUB_ForumEntities _db;

        public ModeratorRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Moderator obj)
        {
            _db.Moderators.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Moderator Get(int id)
        {
            return _db.Moderators.FirstOrDefault(x => x.ModeratorId == id);
        }

        public List<Moderator> Get()
        {
            return _db.Moderators.ToList();
        }

        public bool Edit(Moderator obj)
        {
            var p = _db.Moderators.FirstOrDefault(en => en.ModeratorId == obj.ModeratorId);
            _db.Entry(p).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Moderators.FirstOrDefault(e => e.ModeratorId == id);
            if (c == null)
            {
                return false;
            }

            _db.Moderators.Remove(c);
            return true;
        }


    }
}
