using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AmenityRepository : IAmenityRepository

    {
        private readonly AsyncDbContext _context;

        public AmenityRepository(AsyncDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Amenity>> Amenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenity> GetAmenity(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task PostAmenity(Amenity amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutAmenity(Amenity amenity)
        {
            _context.Entry(amenity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                // Save worked
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenityExists(amenity.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool AmenityExists(int id)
        {
            return _context.Amenities.Any(e => e.Id == id);
        }

        public Task DeleteAmenity(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public Task<Amenity> Amenity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
