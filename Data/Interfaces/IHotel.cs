using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public
        interface IHotel
    {
        
        Task<IEnumerable<HotelModel>> GetHotels();

        Task<HotelModel> GetHotel(int id);

        Task<bool> DeleteHotel(int id);

        Task PostHotel(HotelModel hotel);

        Task<bool> PutHotel(HotelModel hotel);

    }
}
