using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Nodak.Models;

namespace Nodak.FluentEntitis
{
    public class FluentEntitis : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(v => v.Courses)
                .WithRequired(c => c.Student)
                .HasForeignKey(h => h.Student.Id);


        }
    }
}