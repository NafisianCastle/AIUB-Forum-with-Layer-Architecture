using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class AnswerCommentRepo : IRepository<AnswerComment, int>
    {
        private AIUB_ForumEntities db;
        public AnswerCommentRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(AnswerComment obj)
        {
            db.AnswerComments.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == id);
            if (oobj == null)
            {
                return false;
            }

            db.AnswerComments.Remove(oobj);

            return db.SaveChanges() == 1;
        }

        public bool Edit(AnswerComment obj)
        {
            var oobj = db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == obj.AnsCmntId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public AnswerComment Get(int id)
        {
            return db.AnswerComments.FirstOrDefault(x => x.AnsCmntId == id);
        }

        public List<AnswerComment> Get()
        {
            return db.AnswerComments.ToList();
        }
    }
}
