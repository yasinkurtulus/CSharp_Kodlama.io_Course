using CafeProject.Abstract;
using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Concrete
{
    class MersisCheckManager : ICustomerCheckService
    {
        public bool check(Customer cutomer)
        {
            return true;
        }
    }
}
