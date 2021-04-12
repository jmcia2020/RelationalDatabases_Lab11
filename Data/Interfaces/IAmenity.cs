using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IAmenity
    {
        Task<IEnumerable<Amenity>> Amenities();

        Task<Amenity> Amenity(int id);

        Task DeleteAmenity(Amenity amenity);

        Task PostAmenity(Amenity amenity);

        Task<bool> PutAmenity(Amenity hotel);
    }
}
