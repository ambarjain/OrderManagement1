using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public interface IPaymentFactory
    {
        IPayment GetPaymentObject();
    }
}
