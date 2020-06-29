using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class VideoPayment : IPayment
    {
        OrderItem _orderItem;
        public VideoPayment(OrderItem orderItem)
        {
            _orderItem = orderItem;
        }
        public void DoAction()
        {
           if(_orderItem.Name.Equals("Learning To Ski"))
            {
                Console.WriteLine("Adding a free \"First Aid\" video to the packing slip ");
                Console.ReadLine();
            }
        }
    }
}
