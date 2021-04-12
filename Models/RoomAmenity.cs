using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenity
    {
        public int RoomId { get; set; }
        public int AmenityId { get; set; }

        //Navigation Properties

        public Room Room { get; set; }

        public Amenity Amenitiy { get; set; }
    }
}
