﻿using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public
        interface IHotelRepository
    {
        
        Task<IEnumerable<Hotel>> GetHotels();

        Task<Hotel> GetHotel(int id);

        Task DeleteHotel(Hotel hotel);

        Task PostHotel(Hotel hotel);

        Task<bool> PutHotel(Hotel hotel);
    }
}