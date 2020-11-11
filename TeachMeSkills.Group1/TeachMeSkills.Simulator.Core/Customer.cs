using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
	public class Customer
	{
		public string Name { get; set; }
		public string Id { get; set; }
		public readonly List<Product> Basket = new List<Product>();

		public Customer()
		{
			var random = new Random();
			int productsToCreate = random.Next(1, 10);
			Id = Guid.NewGuid().ToString().Substring(0, 5);

			for (int i = 0; i < productsToCreate; i++)
			{
				Basket.Add(new Product());
			}
		}
	}
}