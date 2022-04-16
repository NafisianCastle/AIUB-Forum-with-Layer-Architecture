using DAL.Database;
using DAL.Repo;

namespace DAL
{
    public static class DataAccessFactory
    {
        private static readonly AIUB_ForumEntities Db = new AIUB_ForumEntities();
        public static IRepository<Admin, int> AdminDataAccess()
        {
            return new AdminRepo(Db);
        }
        public static IRepository<Moderator, int> ModeratorDataAccess()
        {
            return new ModeratorRepo(Db);
        }
        public static IRepository<User, int, string> UserDataAccess()
        {
            return new UserRepo(Db);
        }
        public static IRepository<Post, int> PostDataAccess()
        {
            return new PostRepo(Db);
        }
        public static IRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(Db);
        }
        public static IRepository<Company, int> CompanyDataAccess()
        {
            return new CompanyRepo(Db);
        }
        public static IRepository<Job, int> JobDataAccess()
        {
            return new JobRepo(Db);
        }
        public static IRepository<JobPost, int> JobPostDataAccess()
        {
            return new JobPostRepo(Db);
        }
        public static IRepository<Answer, int> AnswerDataAccess()
        {
            return new AnswerRepo(Db);
        }
        public static IRepository<AnswerComment, int> AnswerCommentDataAccess()
        {
            return new AnswerCommentRepo(Db);
        }
        public static IRepository<Badge, int> BadgeDataAccess()
        {
            return new BadgeRepo(Db);
        }
        public static IRepository<Vote, int> VoteDataAccess()
        {
            return new VoteRepo(Db);
        }
        public static IAuth<bool> AuthAccess()
        {
            return new UserRepo(Db);
        }
        public static IAuth<Token> AuthDataAccess()
        {
            return new TokenRepo(Db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(Db);
        }
    }
}