using AsyncInn.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsyncInn.Controllers
{
    [Route("/api/Hotels/{hotelId}/Rooms")]
    [ApiController]
    public class HotelRoomsController : ControllerBase
    {
        //private readonly AsyncDbContext _context;
        IHotelRoom _hotelRoomRepository;

        public HotelRoomsController(IHotelRoom hotelRoomRepository)
        {
            _hotelRoomRepository = hotelRoomRepository;
            //this.hotelRoomRepository = hotelRoomRepository;
        }


        // GET: api/<HotelRoomController> 
        [HttpGet]  // /api/Hotels/{hotelId}/Rooms
        public IEnumerable<string> GetHotelRoom(int hotelId)
        {
            return new string[] { "hotelId", "roomNumber" };
        }

        // GET api/<HotelRoomController>/5 
        [HttpGet("{roomNumber}")] // /api/Hotels/{hotelId}/Rooms/{roomNumber}
        public string Get(int hotelId, int roomNumber)
        {
            return "value";
        }

        // POST api/<HotelRoomController>
        [HttpPost] // //api/Hotels/{hotelId}/Rooms
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HotelRoomController>/5
        //[HttpPut("{roomNumber}")] // /api/Hotels/{hotelId}/Rooms/{roomnumber}
        //public void Put(int hotelId, int roomNumber, [FromBody] PutHotelRoom model)
        //{
        //}

        // DELETE api/<HotelRoomController>/5
        [HttpDelete("{roomNumber}")] // /api/Hotels/{hotelId}/Rooms/{roomnumber}
        public void Delete(int hotelId, int roomNumber)
        {
        }
    }
}
