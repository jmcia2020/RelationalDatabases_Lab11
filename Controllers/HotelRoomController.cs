using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AsyncInn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        // GET: api/<HotelRoomController> 
        [HttpGet]  // /api/Hotels/{hotelId}/Rooms
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HotelRoomController>/5 
        [HttpGet("{id}")] // /api/Hotels/{hotelId}/Rooms/{roomNumber}
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HotelRoomController>
        [HttpPost] // //api/Hotels/{hotelId}/Rooms
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HotelRoomController>/5
        [HttpPut("{id}")] // /api/Hotels/{hotelId}/Rooms/{roomNumber
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HotelRoomController>/5
        [HttpDelete("{id}")] // /api/Hotels/{hotelId}/Rooms/{roomNumber}
        public void Delete(int id)
        {
        }
    }
}
