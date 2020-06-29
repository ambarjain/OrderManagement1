using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessingSystem
{
    public class Order
    {
        
        public List<OrderItem> orderItems = new List<OrderItem>();
        double total = 0.0;
        public double CalculatePayableAmount()
        {
            double total = 0.0;
            foreach (var order in orderItems)
            {
              total = total + (order.Price * order.Quantity); 
            }            
            return total;
        }
        
    }
}
