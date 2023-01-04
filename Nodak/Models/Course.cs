using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nodak.Models
{
    public class Course
    {
        public Course()
        {
                Id = Guid.NewGuid();    
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsPass { get; set; }
        public int Score { get; set; }
    }
}