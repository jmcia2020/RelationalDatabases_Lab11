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
        public DbSet<HotelModel> Hotels { get; set; }

        public DbSet<RoomModel> Rooms { get; set; }

        public DbSet<AmenityModel> Amenities { get; set; }

        public DbSet<RoomAmenityModel>RoomAmenities { get; set; }

        public AsyncDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel> ().HasData(
                new RoomModel
                {
                    Id = 1,
                    Name = "Minimalist",
                    Layout = 0
                },

                new RoomModel
                {
                    Id = 2,
                    Name = "Posh",
                    Layout = 2
                },

                new RoomModel
                {
                    Id = 3,
                    Name = "JustRight",
                    Layout = 1
                });

            modelBuilder.Entity<HotelModel>().HasData(
                new HotelModel
                {
                    Id = 1,
                    Name = "Hotel6",
                    StreetAddress = "123 Skid Row",
                    City = "New York",
                    State = "NY",
                    Country = "USA",
                    Phone = "555-555-1234"
                },

                new HotelModel
                {
                    Id = 2,
                    Name = "Le Meridien",
                    StreetAddress = "123 Madison Avenue",
                    City = "New York",
                    State = "NY",
                    Country = "USA",
                    Phone = "555-555-1235"
                },

                new HotelModel
                {
                    Id = 3,
                    Name = "Fairfield Inn",
                    StreetAddress = "123 Rockwell Road",
                    City = "Cedar Rapids",
                    State = "Iowa",
                    Country = "USA",
                    Phone = "555-555-1236"
                });

            modelBuilder.Entity<AmenityModel>().HasData(
                new AmenityModel
                {
                    Id = 1,
                    Name = "Toothbrush"
                },

                new AmenityModel
                {
                    Id = 2,
                    Name = "Spa"
                },

                new AmenityModel
                {
                    Id = 3,
                    Name = "Pool"
                });


            modelBuilder.Entity<HotelRoomModel>()
                .HasKey(hotelRoom => new
                {
                    hotelRoom.HotelId,
                    hotelRoom.RoomId,
                }); 


            modelBuilder.Entity<RoomAmenityModel>()
                .HasKey(roomAmenity => new
                {
                    roomAmenity.RoomId,
                    roomAmenity.AmenityId,
                });
        }
    }

}
