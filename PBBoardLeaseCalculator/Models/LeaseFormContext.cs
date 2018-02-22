using Microsoft.EntityFrameworkCore;

namespace PBBoardLeaseCalculator.Models
{
    public class LeaseFormContext: DbContext
    {
        public LeaseFormContext(DbContextOptions<LeaseFormContext> options)
        :base(options)
        {

        }

        public DbSet<LeaseForm> LeaseForms{get;set;}
    }
}