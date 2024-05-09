using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPocket.Data;
using EcoPocket.Models;
using EcoPocket.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcoPocket.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly EcoPocketDbContextBase _EcoPocketContext;

        public IncomeService(EcoPocketDbContextBase vpEcoPocketContext)
        {
            _EcoPocketContext = vpEcoPocketContext;
        }

        public async Task<List<Income>> GetAllIncomesAsync()
        {
            return await _EcoPocketContext.Income.Include(i => i.IncomeCategory).ToListAsync();
        }
    }
}
