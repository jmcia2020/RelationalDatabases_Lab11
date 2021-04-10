using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class HotelRoomRepository : IHotelRoomRepository

    {
        public Task<bool> DeleteHotelRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetHotelRooms()
        {
            throw new NotImplementedException();
        }

        public Task PostHotelRoom(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutHotelRoom(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
