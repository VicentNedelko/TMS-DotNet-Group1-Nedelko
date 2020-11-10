using TeachMeSkills.Simulator.Core.Enums;
using System;
using System.Collections.Generic;
using TeachMeSkills.Simulator.Core;
using Nest;

namespace TeachMeSkills.Simulator.Cons
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var customer = new Customer();

			var product = new Product();

			Console.WriteLine(string.Format("Customer with {0} products has been created.", customer.Basket.Count));

			Console.ReadLine();

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
		public class Product
		{
			public readonly List<Product> Name = new List<Product>();

			public readonly List<Product> Prise = new List<Product>();

            public Product()
			{
				var random = new Random();
				var Name = random.Next(1, 10);

				for (int i = 0; i < Name; i++)
				{
					this.Name.Add(new Product());
				}

				var random1 = new Random();
				var Prise = random.Next(1, 10);

				for (int i = 0; i < Prise; i++)
				{
					this.Prise.Add(new Product());
				}

			}
		}
	}
}