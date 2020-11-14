using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
    public class Customer
    {
        static object locker = new object();
        public List<Product> Basket { get; set; }
        public string Id { get; set; }
        public Customer()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 5);
            Basket = new List<Product>();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                Basket.Add(new Product());
            }
        }
        public void PrintCustomerInfo()
        {
            List<decimal> basketValue = new List<decimal>();
            decimal basketSum = 0;
            lock (locker)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------");
                Console.WriteLine($"Customer Id - {this.Id}");
                Console.WriteLine("BASKET : ");
                foreach (Product product in Basket)
                {
                    Console.WriteLine($"{product.Name} - {product.Price:0.00} BYN");
                    basketValue.Add(product.Price);
                    basketSum += product.Price;
                }
                Console.WriteLine($"TOTAL : {basketSum:00.00} BYN");
            }
        }
    }
}