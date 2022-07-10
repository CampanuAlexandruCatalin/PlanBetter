using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyHotel.Domain.Entities;
using MyHotel.Persistance.Data.Mappings;

namespace MyHotel.Persistance.Data
{
    public class MyHotelDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public MyHotelDbContext(DbContextOptions<MyHotelDbContext> options)
              : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(local)\SQLEXPRESS;Database=MyHotel;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(@connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GuestMapping.Map(modelBuilder);
            ReservationMapping.Map(modelBuilder);
            RoomMapping.Map(modelBuilder);
            SeedDatabase(modelBuilder);
        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(new List<Room>()
            {
                new Room()
                {
                    Id = 1,
                    Capacity = 2,
                    Price = 50,
                    Facilities = "bathroom",
                    RoomNumber = 101,
                    Status = "available"
                },
                new Room()
                {
                    Id = 2,
                    Capacity = 2,
                    Price = 50,
                    Facilities = "bathroom",
                    RoomNumber = 102,
                    Status = "available"
                },
                new Room()
                {
                    Id = 3,
                    Capacity = 1,
                    Price = 100,
                    Facilities = "clean bathroom",
                    RoomNumber = 103,
                    Status = "unavailable"
                },
                new Room()
                {
                    Id = 4,
                    Capacity = 1,
                    Price = 125,
                    Facilities = "big TV",
                    RoomNumber = 104,
                    Status = "available"
                },
                new Room()
                {
                    Id = 5,
                    Capacity = 2,
                    Price = 150,
                    Facilities = "WIFI",
                    RoomNumber = 105,
                    Status = "unavailable"
                }
            });
        }
    }
}
