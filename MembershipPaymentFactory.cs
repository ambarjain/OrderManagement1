using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class MembershipPaymentFactory : IPaymentFactory
    {
        OrderItem _orderItem;
        public MembershipPaymentFactory(OrderItem orderItem)
        {
            _orderItem = orderItem;
        }
        public IPayment GetPaymentObject()
        {
            return new MembershipPayment(_orderItem);
        }
    }
}
