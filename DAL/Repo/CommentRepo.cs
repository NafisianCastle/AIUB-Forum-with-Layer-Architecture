﻿using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class CommentRepo : IRepository<Comment, int>
    {
        private AIUB_ForumEntities db;
        public CommentRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Comment obj)
        {
            db.Comments.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = db.Comments.FirstOrDefault(x => x.CommentId == id);
            if (oobj == null)
            {
                return false;
            }

            db.Comments.Remove(oobj);
            return db.SaveChanges() == 1;
        }

        public bool Edit(Comment obj)
        {
            var oobj = db.Comments.FirstOrDefault(x => x.CommentId == obj.CommentId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public Comment Get(int id)
        {
            return db.Comments.FirstOrDefault(x => x.CommentId == id);
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }
    }
}
