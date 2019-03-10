using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class SchoolContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(p => p.Person)
                .WithOne(i => i.Student)
                .HasForeignKey<Student>(b => b.person_id);
        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Person> Person { get; set; }
    }
} 