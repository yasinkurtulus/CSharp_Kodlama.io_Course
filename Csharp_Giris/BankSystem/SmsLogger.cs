using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class SmsLogger : LogService
    {
        public void Log()
        {
            Console.WriteLine("Sms has been send");
        }
    }
}
