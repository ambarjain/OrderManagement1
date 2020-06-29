using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem
{
    public class OrderItem
    {

        //public List<Product> products=new List<Product>();
        //public List<Book> books = new List<Book>();
        //public List<Membership> memberships = new List<Membership>();
        //public List<Video> videos = new List<Video>();
        public string Category;
        public int Id;
        public string Name;
        public int Quantity;
        public double Price;
        public bool IsMembership;
        public bool IsUpgrade;
    }
}
