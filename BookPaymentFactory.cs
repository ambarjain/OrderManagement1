using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    class BookPaymentFactory : IPaymentFactory
    {
        
        public IPayment GetPaymentObject()
        {
            return new BookPayment();
        }
    }
}
