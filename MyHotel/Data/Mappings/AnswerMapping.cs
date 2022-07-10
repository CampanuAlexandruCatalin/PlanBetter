using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class AnswerMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .Property(s => s.Id)
                .HasColumnName("AnsId")
                .IsRequired();

            modelBuilder.Entity<Answer>()
                .Property(s => s.Id)
                .HasColumnName("QstId")
                .IsRequired();

            modelBuilder.Entity<Answer>()
                .Property(s => s.AnswerText)
                .HasColumnName("Answer_text")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
