using EcoPocket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPocket.Services.Interfaces
{
    public interface IIncomeService
    {
        Task<List<Income>> GetAllIncomesAsync();
    }
}
