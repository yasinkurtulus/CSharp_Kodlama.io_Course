using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class HouseCredit : ICreditManager
    {
        public void CalculateCredit()
        {
            Console.WriteLine("house credit is calculating");
        }
    }
}
