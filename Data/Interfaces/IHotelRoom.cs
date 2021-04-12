using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IHotelRoom

    {
        Task<IEnumerable<Hotel>> GetHotelRooms(int hotelId);

        Task<Hotel> GetHotelRoom(int hotelId, int roomNumber);

        Task<bool> DeleteHotelRoom(int hotelId, int roomNumber);

        Task PostHotelRoom(int hotelId, int roomNumber);

        Task<bool> PutHotelRoom(int hotelId, int roomNumber);
    }
}
