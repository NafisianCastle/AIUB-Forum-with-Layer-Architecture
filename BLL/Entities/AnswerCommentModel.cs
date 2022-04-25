using System;

namespace BLL.Entities
{
    public class AnswerCommentModel
    {
        public int AnsCmntId { get; set; }
        public int AnsId { get; set; }
        public int Score { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}