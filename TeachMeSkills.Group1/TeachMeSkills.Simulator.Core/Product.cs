using System;
using System.Collections.Generic;
using System.Text;
using TeachMeSkills.Simulator.Core.Enums;

namespace TeachMeSkills.Simulator.Core
{

    public class Product
    {
        public ProductName Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            var random = new Random();
            Price = (decimal)random.NextDouble() * 10;
            switch (random.Next(1, 10))
            {
                case 1:
                    Name = ProductName.Product1;
                    break;
                case 2:
                    Name = ProductName.Product2;
                    break;
                case 3:
                    Name = ProductName.Product3;
                    break;
                case 4:
                    Name = ProductName.Product4;
                    break;
                case 5:
                    Name = ProductName.Product5;
                    break;
                 case 6:
                    Name = ProductName.Product6;
                    break;
                case 7:
                    Name = ProductName.Product7;
                    break;
                case 8:
                    Name = ProductName.Product8;
                    break;
                case 9:
                    Name = ProductName.Product9;
                    break;
                case 10:
                    Name = ProductName.Product10;
                    break;
            }
        }
    }
}