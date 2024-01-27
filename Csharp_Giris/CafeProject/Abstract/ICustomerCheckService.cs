using CafeProject.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeProject.Abstract
{
    public interface ICustomerCheckService
    {
        bool check(Customer cutomer);
        
    }
}
