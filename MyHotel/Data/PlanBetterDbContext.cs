using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using PlanBetter.Persistance.Data.Mappings;

namespace PlanBetter.Persistance.Data
{
    public class PlanBetterDbContext : DbContext
    {
        
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
            modelBuilder.Entity<Teacher>().HasData(new List<Teacher>()
            {
                new Teacher()
                {
                    Id = 91,
                    Email = "email1@facultate.profesor.com",
                    Password = "parola123",
                    FName = "profesor",
                    LName = "unu",
                    Dob = System.DateTime.Now,
                    Mobile="1234",
                    DateOfJoin=System.DateTime.Now,
                    Status=false,
                    JobTitle="laborant"
                },
                new Teacher()
                {
                    Id = 92,
                    Email = "email2@facultate.profesor.com",
                    Password = "admin123",
                    FName = "profesor",
                    LName = "doi",
                    Dob = System.DateTime.Now,
                    Mobile="07unudoi",
                    DateOfJoin=System.DateTime.Now,
                    Status=true,
                    JobTitle="doc. ing."
                },
                new Teacher()
                {
                    Id = 93,
                    Email = "email3@facultate.profesor.com",
                    Password = "parola",
                    FName = "profesor",
                    LName = "trei",
                    Dob = System.DateTime.Now,
                    Mobile="0777666777",
                    DateOfJoin=System.DateTime.Now,
                    Status=false,
                    JobTitle="profesor laborant"
                }
            });

            modelBuilder.Entity<StudentGroup>().HasData(new List<StudentGroup>()
            {
                new StudentGroup()
                {
                    Id=1301,
                    GroupName="c",
                    StudentId=1
                },
                new StudentGroup()
                {
                    Id=1302,
                    GroupName="ti",
                    StudentId=2
                }
            });

            modelBuilder.Entity<Exam>().HasData(new List<Exam>()
            {
                new Exam()
                {
                    Id = 551,
                    CourseId = 100,
                    TeacherId = 91,
                    GroupId = 1301,
                    Date = System.DateTime.Now,
                    TimeStart = System.DateTime.Now,
                    TimeEnd = System.DateTime.Now,
                    RoomNo = "teams meet",
                    Details="examen grila"

                },
                new Exam()
                {
                    Id = 552,
                    CourseId = 200,
                    TeacherId = 92,
                    GroupId = 1302,
                    Date = System.DateTime.Now,
                    TimeStart = System.DateTime.Now,
                    TimeEnd = System.DateTime.Now,
                    RoomNo = "google meet",
                    Details="examen scris"
                }
            });

            modelBuilder.Entity<Course>().HasData(new List<Course>()
            {
                new Course()
                {
                   Id=200,
                   CourseName="materie1",
                   TeacherId=91,
                   GroupId=1301

                },
                new Course()
                {
                    Id=100,
                   CourseName="materie2",
                   TeacherId=92,
                   GroupId=1302
                }
            }) ;

            modelBuilder.Entity<Question>().HasData(new List<Question>()
            {
                new Question()
                {
                  Id=991,
                  CourseId=200,
                  QuestionText="salut?",
                  StudentId=1
                },
                new Question()
                {
                   Id=992,
                  CourseId=100,
                  QuestionText="?salut?",
                  StudentId=2
                }
            });
            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {
                new Answer()
                {
                    Id=9991,
                    QuestionId=991,
                   AnswerText="da",
                   TeacherId=991

                },
                new Answer()
                {
                   Id=9992,
                   QuestionId=992,
                   AnswerText="da?",
                     TeacherId=992
                }
            });
        }
    }
}
