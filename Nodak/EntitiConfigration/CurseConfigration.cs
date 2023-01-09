using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Nodak.Models;

namespace Nodak.EntitiConfigration
{
    public class CurseConfigration : EntityTypeConfiguration<Course>
    {
        public CurseConfigration()
        {
            
            //Property()<Student>()
            //    .HasMany(v => v.Courses)
            //    .WithRequired(c => c.Student)
            //    .HasForeignKey(h => h.Student.Id);


        }


    }
}