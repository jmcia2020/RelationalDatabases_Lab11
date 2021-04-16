using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Required]
        [StringLength(60)]
        public string State { get; set; }

        [Required]
        [StringLength(60)]
        public string Country { get; set; }

        [Required]
        [StringLength(60)]
        public string Phone { get; set; }

        //public List<HotelRoomDTO> Rooms { get; set; }
    }
}