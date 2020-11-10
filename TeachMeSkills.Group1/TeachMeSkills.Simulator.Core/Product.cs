using System;
using System.Collections.Generic;
using System.Text;
using TeachMeSkills.Simulator.Core.Enums;

namespace TeachMeSkills.Simulator.Core
{

    public class Product
    {
        public int ProductId { get; set; }

        public Name  Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

    }
}