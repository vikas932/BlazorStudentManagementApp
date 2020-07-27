using Microsoft.EntityFrameworkCore;
using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Student>()
            //    .HasMany(c => c.Subject)
            //    .WithOne(e => e.student);

            //Seed Subject Table
            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectId = 1, SubjectName = "Data Structures", Marks = 80 });
            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectId = 2, SubjectName = "Algo", Marks = 78 });
            

            // Seed Student Table
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                FirstName = "John",
                LastName = "Smith",
                SubjectId = 1
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 2,
                FirstName = "Abhi",
                LastName = "Girase",
                SubjectId = 2

            });

        }
    }
}
