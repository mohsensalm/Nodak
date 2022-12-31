using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nodak.Models
{
    public class Student
    {
        public Student()
        {
                
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public float Average { get; set; }
        public int ClassNumber { get; set; }

        public  IQueryable<Course>Courses { get; set; }


    }
}