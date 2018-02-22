using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Models
{
    public class PriceChart : BaseEntity
    {
        public long Id {get;set;}
        public State Location {get;set;}       
        public BoardSize BoardSize {get;set;}
        public int Price {get;set;}

        public DateTime EffectiveDate {get;set;}
    }
}
