using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class CourseMapping
    {
        internal static void Course(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(s => s.Id)
                .HasColumnName("CourseId")
                .IsRequired();


            modelBuilder.Entity<Course>()
                .Property(s => s.CourseName)
                .HasColumnName("CourseName")
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .Property(s => s.Group_Id)
                .HasColumnName("GropuId")
                .IsRequired();
        }
    }
}
