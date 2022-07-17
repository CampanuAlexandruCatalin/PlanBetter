using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using PlanBetter.Persistance.Data.Mappings;

namespace PlanBetter.Persistance.Data
{
    public class PlanBetterDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(local)\SQLEXPRESS;Database=PlanBetter;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(@connectionString);
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Exam> Exams { get; set; } 
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
       
        

        public PlanBetterDbContext(DbContextOptions<PlanBetterDbContext> options)
              : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
            
            StudentMapping.Map(modelBuilder);
            ExamMapping.Map(modelBuilder);
            SeedDatabase(modelBuilder);
        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Email = "email1@facultate.student.com",
                    Password = "parola123",
                    FName = "student",
                    LName = "unu",
                    Dob = System.DateTime.Now,
                    Mobile="1234",
                    DateOfJoin=System.DateTime.Now,
                    Status=false

                },
                new Student()
                {
                    Id = 2,
                    Email = "email2@facultate.student.com",
                    Password = "admin123",
                    FName = "student",
                    LName = "doi",
                    Dob = System.DateTime.Now,
                    Mobile="07unudoi",
                    DateOfJoin=System.DateTime.Now,
                    Status=true
                },
                new Student()
                {
                    Id = 3,
                    Email = "email3@facultate.student.com",
                    Password = "parola",
                    FName = "student",
                    LName = "trei",
                    Dob = System.DateTime.Now,
                    Mobile="0777666777",
                    DateOfJoin=System.DateTime.Now,
                    Status=false
                }
            });
            /*
            modelBuilder.Entity<Exam>().HasData(new List<Exam>()
            {
                new Exam()
                {
                    Id = 1,
                 CourseId = 100,
                    TeacherId = 13,
                    GroupId = 33,
                    Date = System.DateTime.Now,
                    TimeStart = System.DateTime.Now,
                    TimeEnd = System.DateTime.Now,
                    RoomNo = "parter",
                    Details="examen grila"

                },
                new Exam()
                {
                    Id = 2,
                   CourseId = 200,
                    TeacherId = 3,
                    GroupId = 43,
                    Date = System.DateTime.Now,
                    TimeStart = System.DateTime.Now,
                    TimeEnd = System.DateTime.Now,
                    RoomNo = "etajul2",
                    Details="examen scris"
                }
            });
            
            */
        }
    }
}
