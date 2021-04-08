using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AmenityRepository : IAmenityRepository

    {
        public Task<IEnumerable<Amenity>> Amenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenity> Amenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAmenity(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public Task PostAmenity(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutAmenity(Amenity hotel)
        {
            throw new NotImplementedException();
        }
    }
}
