using Microsoft.EntityFrameworkCore;

namespace PBBoardLeaseCalculator.Models
{
    public class LeaseFormContext: DbContext, IDbContext
    {
        public LeaseFormContext()
       : base()
        {

        }

        public LeaseFormContext(DbContextOptions<LeaseFormContext> options)
        :base(options)
        {

        }

        public DbSet<LeaseForm> LeaseForms{get;set;}
    }
}