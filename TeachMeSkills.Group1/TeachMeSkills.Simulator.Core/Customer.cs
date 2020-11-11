using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
	public class Customer
	{
		public string Name { get; set; }

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