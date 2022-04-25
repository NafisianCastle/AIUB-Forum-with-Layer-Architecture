using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    public class AnswerRepo : IRepository<Answer, int>
    {
        private readonly AIUB_ForumEntities _db;

        public AnswerRepo(AIUB_ForumEntities db)
        {
            _db = db;
        }

        public bool Add(Answer obj)
        {
            _db.Answers.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = _db.Answers.FirstOrDefault(x => x.AnsId == id);
            if (oobj == null) return false;

            _db.Answers.Remove(oobj);
            return _db.SaveChanges() == 1;
        }

        public bool Edit(Answer obj)
        {
            var oobj = _db.Answers.FirstOrDefault(x => x.AnsId == obj.AnsId);
            _db.Entry(oobj).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public Answer Get(int id)
        {
            return _db.Answers.FirstOrDefault(x => x.AnsId == id);
        }

        public List<Answer> Get()
        {
            return _db.Answers.ToList();
        }
    }
}