using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    class BookPayment : IPayment
    {
        public void DoAction()
        {
            Console.WriteLine( "Creating a dupicate Packaging slip for royalty department");
            Console.ReadLine();
            GenerateCommissionPayment();
        }
        private void GenerateCommissionPayment()
        {
            Console.WriteLine("Generating Commission payment to the agent");
            Console.ReadLine();
        }
    }
}
