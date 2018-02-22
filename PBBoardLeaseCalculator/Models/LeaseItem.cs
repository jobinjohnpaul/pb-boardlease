using System;

namespace PBBoardLeaseCalculator.Models
{
    public class LeaseItem
    {
        public int Id { get; set; }

        public LeaseForm LeaseForm { get; set; }

        public double Price { get; set; }
        public BoardSize BoardSize { get; set; }
        public int AppliedDiscount { get; set; }

        public DateTime LeaseFromDate { get; set; }
        public DateTime LeaseToDate { get; set; }
    }
}
