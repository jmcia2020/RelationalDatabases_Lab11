using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class HotelRoomRepository : IHotelRoom

    {
       public Task<bool> DeleteHotelRoom(int hotelId, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelRoom(int hotelId, int roomNumber)
        {
            throw new NotImplementedException();
        }

       public Task<IEnumerable<Hotel>> GetHotelRooms(int hotelId)
        {
            throw new NotImplementedException();
        }

        public Task PostHotelRoom(int hotelId, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutHotelRoom(int hotelId, int roomNumber)
        {
            throw new NotImplementedException();
        }
    }
}
