﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalesSystem.DAL.Entities;

namespace TicketSalesSystem.BLL.DTOs
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public Decimal Price { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public int SeatTypeId { get; set; }
        public bool IsConfirmed { get; set; }
        public Flight? Flight { get; set; }
    }
}
