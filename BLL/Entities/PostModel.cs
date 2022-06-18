using System;

namespace BLL.Entities
{
    public class PostModel
    {
        public int PostId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int Score { get; set; }
        public int Views { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public int AnswerCount { get; set; }
        public int ComentsCount { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}