using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class RoomMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<Room>()
                .Property(s => s.RoomNumber)
                .HasMaxLength(3)
                .IsRequired();

            modelBuilder.Entity<Room>()
                .Property(s => s.Capacity)
                .IsRequired();

            modelBuilder.Entity<Room>()
                .Property(s => s.Price)
                .IsRequired();
        }
    }
}
