using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core.Managers
{
    public class CustomerManager
    {
        Random RND = new Random();
        public List<Customer> CustomerGenerator()
        {
            var customers = new List<Customer>();
            for (var i = 0; i < 100; ++i)
            {
                var newCustomer = new Customer
                {
                    id = i + 1,
                    GoodsQuantity = RND.Next(1, 10)
                };
                customers.Add(newCustomer);
            }
            return customers;
        }

    }
}
