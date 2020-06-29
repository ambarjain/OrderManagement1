using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    class ProductPayment : IPayment
    {
        public void DoAction()
        {
            Console.WriteLine("Generating Packaging slip for shipping");
            Console.ReadLine(); GenerateCommissionPayment();
        }
        private void GenerateCommissionPayment()
        {
            Console.WriteLine("Generating Commission payment to the agent");
            Console.ReadLine();
        }
    }
}
