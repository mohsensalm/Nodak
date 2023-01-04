using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Nodak.Models;

namespace Nodak.Data
{
    public class NodakContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NodakContext() : base("name=NodakContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .HasMany(v=>v.Courses)
            //    .WithOptional(e=>e.Id)

            //    .Property(t => t.Name)
            //    .HasMaxLength(90)
            //    .IsRequired();
        }

        public System.Data.Entity.DbSet<Nodak.Models.Student> Students { get; set; }
        public System.Data.Entity.DbSet<Nodak.Models.Teacher> Teachers { get; set; }
        public System.Data.Entity.DbSet<Nodak.Models.Course> Courses { get; set; }



    }
}
