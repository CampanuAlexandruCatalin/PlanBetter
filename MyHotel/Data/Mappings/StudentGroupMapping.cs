using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class StudentGroupMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentGroup>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<StudentGroup>()
                .Property(s => s.StudentId)
                .HasColumnName("StudentId")
                .IsRequired();

            modelBuilder.Entity<StudentGroup>()
                .Property(s => s.GroupName)
                .HasColumnName("GroupName")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
