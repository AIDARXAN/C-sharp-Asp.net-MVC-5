using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetanitASP_NET_MVC5.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; } // purchase id
        public string Person { get; set; }  // name surname of customer
        public string Address { get; set; } //customer address
        public int BookId { get; set; } //book id
        public DateTime Date { get; set; } //Purchase date

      
    }
}