using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
    public class Seller
    {
        public int SellerId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
