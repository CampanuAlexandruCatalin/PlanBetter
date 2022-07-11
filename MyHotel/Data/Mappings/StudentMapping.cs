using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class StudentMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .HasColumnName("StudentId")
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Password)
                .HasColumnName("Pass")
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.FName)
                .HasColumnName("Fname")
                .HasMaxLength(20)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.LName)
                .HasColumnName("Lname")
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Dob)
                .HasColumnName("Dob")
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.Mobile)
                .HasColumnName("Mobile")
                .HasMaxLength(15)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.DateOfJoin)
                .HasColumnName("DateOfJoin")
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.Status)
                .HasColumnName("Status")
                .IsRequired();
        }
    }
}
