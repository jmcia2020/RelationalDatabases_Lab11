using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IAmenity
    {
        Task<IEnumerable<AmenityModel>> Amenities();

        Task<AmenityModel> Amenity(int id);

        Task DeleteAmenity(AmenityModel amenity);

        Task PostAmenity(AmenityModel amenity);

        Task<bool> PutAmenity(AmenityModel hotel);
        
        Task GetAmenities();

        Task GetAmenity(int id);
    }
}
