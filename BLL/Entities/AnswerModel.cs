using System;

namespace BLL.Entities
{
    public class AnswerModel
    {
        public int AnsId { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int PostId { get; set; }
        public int Score { get; set; }
        public int AnsUserId { get; set; }
    }
}