using System;
using System.Collections.Generic;
using System.Text;
using Course.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.CourseDBC
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
        }
       
         public DbSet<Category> Categories { get; set; }
    }
}
