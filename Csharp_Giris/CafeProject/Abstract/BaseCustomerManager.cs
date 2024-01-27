using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Abstract
{
    public  abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void BuyCoffe(Customer customer)
        {
            Console.WriteLine("Customer Buy a Coffe");
        }

        public  virtual void Save(Customer customer)
        {
            Console.WriteLine("Custoemr saved to DataBase.");
        }
      
    }
}
