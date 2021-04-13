using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public interface IRoom
    {
        //Get All
        Task<IEnumerable<RoomModel>> GetRooms();

        Task<RoomModel> GetRoom(int id);

        Task PostRoom(RoomModel hotel);

        Task<bool> PutRoom(RoomModel room);

        Task<bool> DeleteRoom(int id);

        //Task<bool> RoomExists(int id);

        Task<bool> AddAmenityToRoom(int roomId, int amenityId);

        Task<bool> RemoveAmenityFromRoom(int roomId, int amenityId);
    }
}
