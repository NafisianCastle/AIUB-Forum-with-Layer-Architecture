using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class PostRepo : IRepository<Post, int>
    {
        private readonly AIUB_ForumEntities _db;
        public PostRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Post obj)
        {
            _db.Posts.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = _db.Posts.FirstOrDefault(x => x.PostId == id);
            if (oobj == null) { return false; }

            _db.Posts.Remove(oobj);
            return _db.SaveChanges() != 0;
        }

        public bool Edit(Post obj)
        {
            var oobj = _db.Posts.FirstOrDefault(x => x.PostId == obj.PostId);
            _db.Entry(oobj).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public Post Get(int id)
        {
            return _db.Posts.FirstOrDefault(x => x.PostId == id);
        }

        public List<Post> Get()
        {
            return _db.Posts.ToList();
        }
    }
}
