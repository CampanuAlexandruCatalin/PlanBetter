using Microsoft.EntityFrameworkCore;
using MyHotel.Domain.Entities;

namespace MyHotel.Persistance.Data.Mappings
{
    internal abstract class GuestMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<Guest>()
                .Property(s => s.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Guest>()
                .Property(s => s.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Guest>()
                .Property(s => s.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
