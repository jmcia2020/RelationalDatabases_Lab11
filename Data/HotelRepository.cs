using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class HotelRepository : IHotel
    {
        private readonly AsyncDbContext _context;

        public HotelRepository(AsyncDbContext context)
        {
            _context = context;
        }
            public async Task<HotelModel> GetHotel(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

        public async Task<IEnumerable<HotelModel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync(); 
        }

       public async Task PostHotel(HotelModel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutHotel(HotelModel hotel)
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

        public async Task<bool> DeleteHotel(int id)
        {
            HotelModel hotel = await GetHotel(id);
            if (hotel == null)
            {
                return false;
            }
            _context.Entry(hotel).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return true;
        }             
    }	
}
