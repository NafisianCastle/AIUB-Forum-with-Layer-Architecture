using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class AnswerCommentRepo : IRepository<AnswerComment, int>
    {
        private readonly AIUB_ForumEntities _db;

        public AnswerCommentRepo(AIUB_ForumEntities db)
        {
            _db = db;
        }

        public bool Add(AnswerComment obj)
        {
            _db.AnswerComments.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = _db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == id);
            if (oobj == null)
            {
                return false;
            }

            _db.AnswerComments.Remove(oobj);

            return _db.SaveChanges() == 1;
        }

        public bool Edit(AnswerComment obj)
        {
            var oobj = _db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == obj.AnsCmntId);
            _db.Entry(oobj).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public AnswerComment Get(int id)
        {
            return _db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == id);
        }

        public List<AnswerComment> Get()
        {
            return _db.AnswerComments.ToList();
        }
    }
}