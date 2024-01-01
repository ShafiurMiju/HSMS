namespace DAL.Migrations
{
    using DAL.EF;
    using DAL.EF.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Reflection.Emit;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.HSMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.HSMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            //Student Add
            /*for (int i = 1; i <= 10; i++)
            {
                context.Students.AddOrUpdate(new EF.Models.Student
                {
                    ID = i,
                    FirstName = $"Student{i}",
                    LastName = "Doe",
                    FatherName = $"Father{i}",
                    MotherName = $"Mother{i}",
                    Email = $"student{i}@example.com",
                    ContactNumber = "1234567890",
                    DateOfBirth = DateTime.Now.AddYears(-20).AddMonths(i),
                    Gender = (i % 2 == 0) ? "Male" : "Female",
                    Address = $"Address{i}",
                    Password = $"Password{i}",
                    ClassID = 1, // Replace with the actual ClassID
                    SectionID = 1, // Replace with the actual SectionID
                    AdmissionDate = DateTime.Now.AddYears(-2).AddMonths(i),
                    ProfilePicture = $"profile{i}.jpg",
                    Status = "Active"
                });
            }*/

            /*for (int i = 1; i <= 10; i++)
            {
                context.Teachers.AddOrUpdate(new EF.Models.Teacher
                {
                        ID = i,
                        FirstName = $"Teacher{i}",
                        LastName = "Doe",
                        Email = $"teacher{i}@example.com",
                        ContactNumber = "1234567890",
                        DateOfBirth = DateTime.Now.AddYears(-35).AddMonths(i),
                        Gender = "Male",
                        Education = $"Ph.D. in Subject{i}",
                        Password = "password123",
                        ProfilePicture = $"profile{i}.jpg",
                        DepartmentID = 1 // You may need to adjust the department ID
                    }
                );
            }*/

        }
    }
}
