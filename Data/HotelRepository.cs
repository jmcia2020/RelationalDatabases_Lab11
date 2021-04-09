using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AsyncDbContext _context;

        public HotelRepository(AsyncDbContext context)
        {
            _context = context;
        }
            public async Task<Hotel> GetHotel(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync(); 
        }

       public async Task PostHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutHotel(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                // Save worked
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(hotel.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
        public bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }

        public Task DeleteHotel(Hotel hotel)
        {
            throw new NotImplementedException();

            /*
            public async Task<Hotel> GetHotel(int id)
            Hotel hotel = await GetHotel(id);
            _context.Entry(hotel).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            await _context.SaveChangesAsync();
            */
        }
    }	
}
