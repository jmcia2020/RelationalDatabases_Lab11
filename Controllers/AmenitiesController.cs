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
    [Route("api/Amenities")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {
        //private readonly AsyncDbContext _context;
        IAmenity _amenityRepository;

        public AmenitiesController(IAmenity amenityRepository)           
        {
            _amenityRepository = amenityRepository;
            //this.amenityRepository = amenityRepository;
        }

        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmenityModel>>> GetAmenities()
        {
            var amenities = await _amenityRepository.GetAmenities();     
                return Ok(amenities);

        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmenityModel>> GetAmenity(int id)
        {
            var amenity = await _amenityRepository.Amenities.FindAsync(id);

            if (amenity == null)
            {
                return NotFound();
            }

            return amenity;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenity(int id, AmenityModel amenity)
        {
            if (id != amenity.Id)
            {
                return BadRequest();
            }

            if (!await _amenityRepository.PutAmenity(amenity))
            { 
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Amenities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AmenityModel>> PostAmenity(AmenityModel amenity)
        {
            await _amenityRepository.PostAmenity(amenity);

            return CreatedAtAction("GetAmenity", new { id = amenity.Id }, amenity);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmenity(int id)
        {
            await _amenityRepository.DeleteAmenity(id);
            
                return NotFound();
        }

        private bool AmenityExists(int id)
        {
            return _amenityRepository.Amenities.Any(e => e.Id == id);
        }
    }
}
