using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IHotelRoom

    {
        Task<IEnumerable<Hotel>> GetHotelRooms();

        Task<Hotel> GetHotelRoom(int id);

        Task<bool> DeleteHotelRoom(int id);

        Task PostHotelRoom(Hotel hotel);

        Task<bool> PutHotelRoom(Hotel hotel);
    }
}
