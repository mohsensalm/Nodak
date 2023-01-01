using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nodak.Dtos
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public float Average { get; set; }
        public int ClassNumber { get; set; }

    }
}