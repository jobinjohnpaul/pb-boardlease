using PBBoardLeaseCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Repositories
{
    public class StateRepository : Repository<State>, IDisposable
    {
        public StateRepository(IUnitOfWork unitOfWork) :base(unitOfWork)
        {

        }

    }
}
