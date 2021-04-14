using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IAmenity
    {
        Task<IEnumerable<AmenityModel>> GetAmenities();

        Task<AmenityModel> GetAmenity(int id);

        Task DeleteAmenity(int id);

        Task PostAmenity(AmenityModel amenity);

        Task<bool> PutAmenity(AmenityModel hotel);
    }
}
