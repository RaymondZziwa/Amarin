using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace amarin.Models
{
    public class SchoolDBContext:DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Fees> Fees { get; set; }
    }
}