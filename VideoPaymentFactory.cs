using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class VideoPaymentFactory : IPaymentFactory
    {
        OrderItem _orderItem;
        public VideoPaymentFactory(OrderItem orderItem)
        {
            _orderItem = orderItem;
        }
        public IPayment GetPaymentObject()
        {
            return new VideoPayment(_orderItem);
        }
    }
}
