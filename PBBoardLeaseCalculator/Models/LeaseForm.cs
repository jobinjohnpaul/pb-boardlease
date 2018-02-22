using System.Collections.Generic;

namespace PBBoardLeaseCalculator.Models
{
    public class LeaseForm
    {
        public long Id { get; set; }
        public Customer Customer { get; set; }       
        public Address PropertyAddress { get; set; }

        public ICollection<LeaseItem> LeaseItems { get; set; }
    }
}
