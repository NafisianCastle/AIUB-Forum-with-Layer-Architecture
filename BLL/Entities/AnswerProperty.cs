using System.Collections.Generic;

namespace BLL.Entities
{
    public class AnswerProperty
    {
        public AnswerProperty()
        {
            AnswerComments = new List<AnswerCommentModel>();
            User = new UserModel();
        }

        public List<AnswerCommentModel> AnswerComments { get; set; }
        public UserModel User { get; set; }
    }
}