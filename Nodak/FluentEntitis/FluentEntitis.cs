﻿using System;
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
            //  modelBuilder.Entity<Course>()
              
        }
    }
}