using Jegyek.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Jegyek.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
