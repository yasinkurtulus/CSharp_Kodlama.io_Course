using CafeProject.Abstract;
using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Concrete
{
    public class StarbuckCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService checkService;

        public StarbuckCustomerManager(ICustomerCheckService checkService)
        {
            this.checkService = checkService;
        }

        public override void Save(Customer customer)
        {
            if (checkService.check(customer))
            {
                Console.WriteLine("Customer saved to DB with");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public override void BuyCoffe(Customer customer)
        {
            customer.Stars++;
            Console.WriteLine("Customer won a star");
            Console.WriteLine("Customer has"+customer.Stars+" star");
        }

    }
}
