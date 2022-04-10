using System.Collections.Generic;

namespace BLL.Entities
{
    class PostProperty
    {
        public List<AnswerModel> Answers { get; set; }
        public List<CommentModel> Comments { get; set; }
        public UserModel User { get; set; }
        public PostProperty()
        {
            Answers = new List<AnswerModel>();
            Comments = new List<CommentModel>();
            User = new UserModel();
        }
    }
}
