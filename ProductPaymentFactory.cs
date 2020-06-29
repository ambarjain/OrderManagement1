using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    class ProductPaymentFactory : IPaymentFactory
    {
       
        public IPayment GetPaymentObject()
        {
            return new ProductPayment();
        }
    }
}
