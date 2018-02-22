namespace PBBoardLeaseCalculator.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }        
        public State State { get; set; }
        
    }
}
