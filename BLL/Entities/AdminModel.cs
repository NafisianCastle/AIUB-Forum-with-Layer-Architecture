﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
        public string Description { get; set; }
        public bool IsAdmin { get; set; }
       
    }
}
