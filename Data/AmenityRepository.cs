using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AmenityRepository : IAmenity

    {
        private readonly AsyncDbContext _context;

        public AmenityRepository(AsyncDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AmenityModel>> Amenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<AmenityModel> GetAmenity(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task PostAmenity(AmenityModel amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutAmenity(AmenityModel amenity)
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

        public Task DeleteAmenity(AmenityModel amenity)
        {
            throw new NotImplementedException();
        }

        public Task<AmenityModel> Amenity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
