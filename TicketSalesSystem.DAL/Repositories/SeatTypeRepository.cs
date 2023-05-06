﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalesSystem.DAL.Data;
using TicketSalesSystem.DAL.Entities;
using TicketSalesSystem.DAL.Interfaces;

namespace TicketSalesSystem.DAL.Repositories
{
    internal class SeatTypeRepository : BaseRepository<SeatType>, ISeatTypeRepository
    {
        public SeatTypeRepository(ApplicationContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<SeatType>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().Include(f => f.Airplane).Include(f => f.Tickets).ToListAsync();
        }

        public async override Task<SeatType> GetByIdAsync(int id) => await _dbSet.AsNoTracking().Include(f => f.Airplane).Include(f => f.Tickets).FirstOrDefaultAsync(a => a.Id == id);
    }
}
