using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data;
using AsyncInn.Models;
using AsyncInn.Data.Interfaces;

namespace AsyncInn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        //private readonly AsyncDbContext _context;
        IHotel _hotelRepository;

        public HotelsController(IHotel hotelRepository)
        {
            _hotelRepository = hotelRepository;
            ///this.hotelRepository = hotelRepository;
        }


        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelModel>>> GetHotels()
        {
            var hotels = await _hotelRepository.GetHotels();
            return Ok(hotels);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelModel>> GetHotel(int id)
        {
            var hotel = await _hotelRepository.GetHotel(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, HotelModel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            if (!await _hotelRepository.PutHotel(hotel))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelModel>> PostHotel(HotelModel hotel)
        {
            await _hotelRepository.PostHotel(hotel);

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _hotelRepository.DeleteHotel(id);
            return NoContent();
        }
    }
}
