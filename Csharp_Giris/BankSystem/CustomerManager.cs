using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class CustomerManager
    {
        public void Add(Customer customer,List<Customer> list)
        {
            list.Add(customer);
        }
    }
}
