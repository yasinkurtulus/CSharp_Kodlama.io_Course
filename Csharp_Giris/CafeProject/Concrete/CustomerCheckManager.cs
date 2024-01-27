using CafeProject.Abstract;
using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool check(Customer cutomer)
        {
            return true;
        }
    }
}
