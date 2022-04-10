using System.Collections.Generic;

namespace BLL.Entities
{
    public class AnswerProperty
    {
        public List<AnswerCommentModel> AnswerComments { get; set; }
        public UserModel User { get; set; }
        public AnswerProperty()
        {
            AnswerComments = new List<AnswerCommentModel>();
            User = new UserModel();
        }
    }
}
