using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class RoomRepository : IRoom
    {
        private readonly AsyncDbContext _context;

        public RoomRepository(AsyncDbContext context)
        {
            _context = context;
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }
    
        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task PostRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PutRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                // Save worked
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(room.Id).Result)
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<bool> RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }

        public async Task<bool> DeleteRoom(int id)
        {
            Room room = await GetRoom(id);
            if (room == null)
            {
                return false;
            }
            _context.Entry(room).State = EntityState.Deleted;
            //_context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return true;
        }


        //ADD LOGIC BELOW

       //AddAmenityToRoom(int roomId, int amenityId)


       // RemoveAmentityFromRoom(int roomId, int amenityId)
    }
}
