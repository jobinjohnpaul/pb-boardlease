using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBoardLeaseCalculator.Models
{
    public class Customer
    {
        public long Id {get;set;}
        public string Name {get;set;}       
        public Address MailingAddress {get;set;}
        public string Email {get;set;}
        public string MobileNo {get;set;}
    }
}
