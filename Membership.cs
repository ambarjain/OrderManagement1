using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class Membership
    {
        string Id { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int Quantity { get; set; }
        public bool IsUpgrade { get; set; } 
        
    }
}
