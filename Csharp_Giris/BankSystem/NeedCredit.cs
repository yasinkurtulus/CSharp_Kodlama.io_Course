using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class NeedCredit : ICreditManager
    {
        public void CalculateCredit()
        {
            Console.WriteLine("Need credit is calculating");
        }
    }
}
