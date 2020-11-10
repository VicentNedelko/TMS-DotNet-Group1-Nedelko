using System;
using System.Collections.Generic;
using TeachMeSkills.Simulator.Core;

namespace TeachMeSkills.Simulator.Cons
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var customer = new Customer();

			Console.WriteLine(string.Format("Customer with {0} products has been created.", customer.Basket.Count));

		}
		public class Customer
		{
			private const int MaxProductsInBasket = 10;

			public readonly List<Product> Basket = new List<Product>();

			public Customer()
			{
				var random = new Random();
				int productsToCreate = random.Next(1, 10);

                for (int i = 0; i < productsToCreate; i++)
                {
					this.Basket.Add(new Product());
				}
			}
		}
	}
}