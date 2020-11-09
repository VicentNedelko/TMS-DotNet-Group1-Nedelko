using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TeachMeSkills.Simulator.Core
{
    public class Basket
    {


        public int BasketId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{BasketId} from {Created.ToString("dd.mm.yy hh:mm")}";
        }

    }
}