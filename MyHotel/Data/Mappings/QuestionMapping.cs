using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class QuestionMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .Property(s => s.Id)
                .HasColumnName("QstId")
                .IsRequired();

            modelBuilder.Entity<Question>()
                .Property(s => s.Id)
                .HasColumnName("CourseId")
                .IsRequired();

            modelBuilder.Entity<Question>()
                .Property(s => s.QuestionText)
                .HasColumnName("Question_text")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
