﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }
    }
}
