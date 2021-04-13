                                                  using AsyncInn.Data.Interfaces;
using AsyncInn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Controllers
{
    [Route("api/[controller]")]
  

    [ApiController]
    public class RoomsController : ControllerBase
    {
        //private readonly AsyncDbContext _context;
        IRoom _roomRepository;

        public RoomsController(IRoom roomRepository)
        {
            _roomRepository = roomRepository;
            //this.roomRepository = roomRepository;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomModel>>> GetRooms()
        {
            var rooms = await _roomRepository.GetRooms();
            return Ok(rooms);
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomModel>> GetRoom(int id)
        {
            var room = await _roomRepository.GetRoom(id);            

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, RoomModel room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            if (!await _roomRepository.PutRoom(room))
            {
                return NotFound();
            }

            return NoContent();
        }


        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoomModel>> PostRoom(RoomModel room)
        {
            await _roomRepository.PostRoom(room);

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomRepository.DeleteRoom(id);
            
                return NotFound();  
        }

       //[Route("{roomId}/Amenity/{amenityId}")]  POST
        [HttpPost("{roomId}/Amenity/{amenityId}")] 
        public async Task<IActionResult> AddAmenityToRoom(int roomId, int amenityId)
        {
            if (!await _roomRepository.AddAmenityToRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }


        //[Route("{roomId}/Amenity/{amenityId}")]  DELETE
        [HttpDelete("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> RemoveAmenityFromRoom(int roomId, int amenityId)
        {
            if (!await _roomRepository.RemoveAmenityFromRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
