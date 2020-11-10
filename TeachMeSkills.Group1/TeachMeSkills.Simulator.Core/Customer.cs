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
    }
}