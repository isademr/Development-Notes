using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentRestAPI.Models
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //send Student Table
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "İsa",
                    LastName = "Demir",
                    Email = "dmrisa05@gmail.com",
                    DateOfBirth = new DateTime(1998,4,19),
                    Gender = Gender.Male,
                    DepartmentId=1,
                    PhotoPath = "Images/Demir.png"

                });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 2,
                    FirstName = "Ali",
                    LastName = "Veli",
                    Email = "aliveli@gmail.com",
                    DateOfBirth = new DateTime(1993, 4, 19),
                    Gender = Gender.Male,
                    DepartmentId = 4,
                    PhotoPath = "Images/Veli.png"
                });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 3,
                    FirstName = "Christina",
                    LastName = "Frost",
                    Email = "Chris@gmail.com",
                    DateOfBirth = new DateTime(1987, 12, 5),
                    Gender = Gender.Female,
                    DepartmentId = 2,
                    PhotoPath = "Images/Christina.png"

                });

            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   StudentId = 4,
                   FirstName = "Rachel",
                   LastName = "Stone",
                   Email = "Rachel@gmail.com",
                   DateOfBirth = new DateTime(1982, 7, 5),
                   Gender = Gender.Female,
                   DepartmentId = 3,
                   PhotoPath = "Images/Rachel.png"

               });
        }
    
    }
}
