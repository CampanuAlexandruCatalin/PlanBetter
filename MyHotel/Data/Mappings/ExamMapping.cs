using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class ExamMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .Property(s => s.Id)
                .HasColumnName("ExamId")
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.CourseId)
                .HasColumnName("CourseId")
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.TeacherId)
                .HasColumnName("TeacherId")
                .IsRequired();

            modelBuilder.Entity<Exam>()
                 .Property(s => s.GroupId)
                 .HasColumnName("GroupId")
                 .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.Date)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.TimeStart)
                .HasColumnName("TimeStart")
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.TimeEnd)
                .HasColumnName("TimeEnd")
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.RoomNo)
                .HasColumnName("Room")
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(s => s.Details)
                .HasColumnName("Details")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}

