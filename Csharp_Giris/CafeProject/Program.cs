using CafeProject.Abstract;
using CafeProject.Concrete;
using CafeProject.Entitiy;
using System;

namespace CafeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerCheckService check = new CustomerCheckManager();
            Customer customer1 = new Customer { BirthYear = 1999, FirstName = "Yasin", LastName = "Kurtuluş", Id = 46547843, Stars = 0 };
            BaseCustomerManager starbucksmanager = new StarbuckCustomerManager(check);
            starbucksmanager.Save(customer1);
            BaseCustomerManager espressomanager = new EsproLabCustomerManager();
            starbucksmanager.BuyCoffe(customer1);
            espressomanager.BuyCoffe(customer1);

        }
    }
}
