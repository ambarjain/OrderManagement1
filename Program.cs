using System;
using System.Collections.Generic;

namespace OrderProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Order order = new Order();
           
           
            OrderItem orderItem = new OrderItem();
            orderItem.Id = 1;
            orderItem.Name = "Book1";
            orderItem.Quantity = 3;
            orderItem.Price = 100;
            orderItem.Category = "Book";
            order.orderItems.Add(orderItem);

            orderItem = new OrderItem();
            orderItem.Id = 2;
            orderItem.Name = "Membership1";
            orderItem.Quantity = 3;
            orderItem.Price = 100;
            orderItem.Category = "Membership";
            orderItem.IsMembership = true;
            orderItem.IsUpgrade = false;
            order.orderItems.Add(orderItem);

            orderItem = new OrderItem();
            orderItem.Id = 3;
            orderItem.Name = "Product1";
            orderItem.Quantity = 3;
            orderItem.Price = 100;
            orderItem.Category = "Product";
            order.orderItems.Add(orderItem);

            orderItem = new OrderItem();
            orderItem.Id = 4;
            orderItem.Name = "Video1";
            orderItem.Quantity = 3;
            orderItem.Price = 100;
            orderItem.Category = "Video";
            order.orderItems.Add(orderItem);

            orderItem = new OrderItem();
            orderItem.Id = 5;
            orderItem.Name = "Membership2";
            orderItem.Quantity = 3;
            orderItem.Price = 100;
            orderItem.Category = "Membership";
            orderItem.IsMembership = true;
            orderItem.IsUpgrade = true;
            order.orderItems.Add(orderItem);

            double totalAmount=order.CalculatePayableAmount();
            Console.WriteLine("Kindly Pay " + totalAmount + " at checkout");
            Console.ReadLine();
            Console.WriteLine("Payment done successfully");
            Console.ReadLine();
            foreach (var item in order.orderItems)
            {
                
                if (item.Category=="Book")
                {
                    new BookPaymentFactory().GetPaymentObject().DoAction() ;
                }
                else if (item.Category == "Membership")
                {
                    new MembershipPaymentFactory(orderItem).GetPaymentObject().DoAction();
                }
                else if (item.Category == "Product")
                {
                   new ProductPaymentFactory().GetPaymentObject().DoAction();
                }
                else if (item.Category == "Video")
                {
                   new VideoPaymentFactory(orderItem).GetPaymentObject().DoAction();
                }
               
            }
            Console.WriteLine("Order Completed");
            Console.ReadLine();
        }
    }
}
