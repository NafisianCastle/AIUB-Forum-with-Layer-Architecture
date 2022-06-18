using System;

namespace BLL.Entities
{
    public class ModeratorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public bool IsModarator { get; set; }
    }
}