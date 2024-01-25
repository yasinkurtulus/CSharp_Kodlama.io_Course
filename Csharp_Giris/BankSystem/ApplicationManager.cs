using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class ApplicationManager
    {
        public void ApplyCredit(ICreditManager creditman,List<LogService> logList)
        {
            creditman.CalculateCredit();
            foreach (LogService item in logList)
            {
                item.Log();
            }

        }
        public void uniform(List<ICreditManager> list)
        {
            foreach (ICreditManager item in list)
            {
                item.CalculateCredit();
            }
        }
    }
}
