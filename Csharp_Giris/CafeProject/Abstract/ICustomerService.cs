using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void BuyCoffe(Customer customer);
       
    }
}
