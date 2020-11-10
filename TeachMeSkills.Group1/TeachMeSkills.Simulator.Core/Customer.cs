using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
	public class Customer
	{
		public int CustomerId { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}

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