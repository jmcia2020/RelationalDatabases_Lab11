using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenityModel
    {
        public int RoomId { get; set; }
        public int AmenityId { get; set; }

        //Navigation Properties

        public RoomModel Room { get; set; }

        public AmenityModel Amenitiy { get; set; }
    }
}
