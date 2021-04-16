using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoomModel
    {
        public int HotelId { get; set; }

        public int RoomNumber { get; set; }
        
        public decimal Rate { get; set; } 
                   
        public bool PetFriendly { get; set; }

        public int RoomId { get; set; }

        //public RoomDTO Room { get; set; }


        //Navigation Properties

        public HotelModel Hotel { get; set; }

        public RoomModel Room { get; set; }
    }
}
