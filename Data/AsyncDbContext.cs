using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data

{
    public class AsyncDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<RoomAmenity>RoomAmenities { get; set; }

        public AsyncDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room> ().HasData(
                new Room
                {
                    Id = 1,
                    Name = "Minimalist",
                    Layout = 0
                },

                new Room
                {
                    Id = 2,
                    Name = "Posh",
                    Layout = 2
                },

                new Room
                {
                    Id = 3,
                    Name = "JustRight",
                    Layout = 1
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel6",
                    StreetAddress = "123 Skid Row",
                    City = "New York",
                    State = "NY",
                    Country = "USA",
                    Phone = "555-555-1234"
                },

                new Hotel
                {
                    Id = 2,
                    Name = "Le Meridien",
                    StreetAddress = "123 Madison Avenue",
                    City = "New York",
                    State = "NY",
                    Country = "USA",
                    Phone = "555-555-1235"
                },

                new Hotel
                {
                    Id = 3,
                    Name = "Fairfield Inn",
                    StreetAddress = "123 Rockwell Road",
                    City = "Cedar Rapids",
                    State = "Iowa",
                    Country = "USA",
                    Phone = "555-555-1236"
                });

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 1,
                    Name = "Toothbrush"
                },

                new Amenity
                {
                    Id = 2,
                    Name = "Spa"
                },

                new Amenity
                {
                    Id = 3,
                    Name = "Pool"
                });


            modelBuilder.Entity<HotelRoom>()
                .HasKey(hotelRoom => new
                {
                    hotelRoom.HotelId,
                    hotelRoom.RoomId,
                }); 


            modelBuilder.Entity<RoomAmenity>()
                .HasKey(roomAmenity => new
                {
                    roomAmenity.RoomId,
                    roomAmenity.AmenityId,
                });
        }
    }

}
