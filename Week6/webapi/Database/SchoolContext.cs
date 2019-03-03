using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Student)
                .WithOne(i => i.Person)
                .HasForeignKey<Student>(b => b.PersonForeignKey);
            
        }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }

        public class Person
        {

            public int personId {get;set;}
            public string first_name {get;set;}
            public string middle_name {get;set;}
            public string last_name {get;set;}

            public Student Student {get; set;}
        }
        
        public class Student
        {
            public int studentId {get;set;}
            public string email_address {get;set;}

            public int PersonForeignKey {get;set;}
            public Person Person {get;set;}
        }
    }
}