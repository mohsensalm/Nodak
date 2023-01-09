using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nodak.Data;
using Nodak.Models;

namespace Nodak
{
    public class Program
    {
        static void main(string[] args)
        {
            var context = new NodakContext();
            var query =
                from c in context.Courses
                where c.Name == "rizi"
                select c;
            foreach (var curse in query )
            {
                Console.WriteLine(curse.Name); 
            }



        }
    }
}