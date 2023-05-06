﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSalesSystem.DAL.Entities
{
    public class FlightStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Flight> Flights { get; set; } = new List<Flight>();
    }
}
