using System.Collections.Generic;

namespace BLL.Entities
{
    internal class PostProperty
    {
        public PostProperty()
        {
            Answers = new List<AnswerModel>();
            Comments = new List<CommentModel>();
            User = new UserModel();
        }

        public List<AnswerModel> Answers { get; set; }
        public List<CommentModel> Comments { get; set; }
        public UserModel User { get; set; }
    }
}