using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IRoomRepository
    {
        //Get All
        Task<IEnumerable<Room>> GetRooms();

        Task<Room> GetRoom(int id);

        Task<bool> DeleteRoom(Room hotel);

        Task PostRoom(Room hotel);

        Task<bool> PutRoom(Room room);
        Task<bool> DeleteRoom(int id);

        //AddAmenityToRoom(int roomId, int amenityId)

        //RemoveAmentityFromRoom(int roomId, int amenityId)
    }
}
