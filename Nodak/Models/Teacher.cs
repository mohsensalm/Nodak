using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nodak.Models
{
    public class Teacher
    {
        public Teacher()
        {
                
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool IsMarried { get; set; }
        public int InCome { get; set; }
        public IList<Course> Course { get; set; }

    }
}