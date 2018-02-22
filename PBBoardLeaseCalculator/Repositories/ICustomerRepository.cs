using PBBoardLeaseCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Repositories
{
    public interface ICustomerRepository : IDisposable, IRepository<Customer>
    {

    }
}
