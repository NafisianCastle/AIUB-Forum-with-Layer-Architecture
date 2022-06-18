using System;

namespace BLL.Entities
{
    public class VoteModel
    {
        public int VoteId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
    }
}