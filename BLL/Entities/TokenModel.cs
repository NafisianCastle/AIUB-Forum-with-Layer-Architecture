using System;

namespace BLL.Entities
{
    public class TokenModel
    {
        public int Id { get; set; }
        public string Tkey { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int UserId { get; set; }
    }
}