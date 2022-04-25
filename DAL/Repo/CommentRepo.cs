using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    public class CommentRepo : IRepository<Comment, int>
    {
        private readonly AIUB_ForumEntities _db;

        public CommentRepo(AIUB_ForumEntities db)
        {
            _db = db;
        }

        public bool Add(Comment obj)
        {
            _db.Comments.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = _db.Comments.FirstOrDefault(x => x.CommentId == id);
            if (oobj == null) return false;

            _db.Comments.Remove(oobj);
            return _db.SaveChanges() == 1;
        }

        public bool Edit(Comment obj)
        {
            var oobj = _db.Comments.FirstOrDefault(x => x.CommentId == obj.CommentId);
            _db.Entry(oobj).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public Comment Get(int id)
        {
            return _db.Comments.FirstOrDefault(x => x.CommentId == id);
        }

        public List<Comment> Get()
        {
            return _db.Comments.ToList();
        }
    }
}