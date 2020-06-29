using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class MembershipPayment : IPayment
    {
        OrderItem _item;
        public MembershipPayment(OrderItem item)
        {
            _item = item;
        }
        public void DoAction()
        {

            if (_item.IsUpgrade)
            {
                Console.WriteLine("Membership Upgraded");
                Console.ReadLine();
                EmailOwner("Sending Email for upgradtion");
            }
            else
            {
                Console.WriteLine("Membership Activated");
                Console.ReadLine();
                EmailOwner("Sending Email for Activation");
            }

        }

        private void EmailOwner(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
       
    }
}
