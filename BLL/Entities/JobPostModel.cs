using System;

namespace BLL.Entities
{
    public class JobPostModel
    {
        public int JpId { get; set; }
        public DateTime JpCreationDate { get; set; }
        public DateTime? JpDeleteDate { get; set; }
        public int Views { get; set; }
        public string Body { get; set; }
        public int JobId { get; set; }
        public string Title { get; set; }
    }
}