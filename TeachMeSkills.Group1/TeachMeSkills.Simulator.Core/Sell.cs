using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
    public class Sell
    {
        public int SellId { get; set; }

        public int BasketId { get; set; }

        public int ProductId { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Product Product { get; set; }
    }
}
