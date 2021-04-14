using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomModel
    {

        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [Range(0, 2)]
        public int Layout { get; set; }

        //public List<AmenityDTO> Amenities { get; set; }
    }
}
