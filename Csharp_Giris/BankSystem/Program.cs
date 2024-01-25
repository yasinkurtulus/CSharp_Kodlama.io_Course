using System;
using System.Collections.Generic;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           /* InduvidualCustomer cust1 = new InduvidualCustomer();
            CoorporateCustomer cust2 = new CoorporateCustomer();
            Customer cust3 = new InduvidualCustomer();
            CustomerManager custman = new CustomerManager();
            List<Customer> customerList = new List<Customer>();
            cust3.CustomerNo = "3";
            cust2.CustomerNo = "2";
            custman.Add(cust2,customerList);
            custman.Add(cust3,customerList);
            Console.WriteLine(customerList[0].CustomerNo);
            Console.WriteLine(customerList[1].CustomerNo);*/
            HouseCredit hcredit1 = new HouseCredit();
            ICreditManager needcredit = new NeedCredit();
            ApplicationManager appman = new ApplicationManager();
            List<LogService> loglist = new List<LogService>();
            SmsLogger smslogger = new SmsLogger();
            LogService databaselog = new DataBaseLogger();
            loglist.Add(smslogger);
            loglist.Add(databaselog);
            appman.ApplyCredit(hcredit1,loglist);
            appman.ApplyCredit(needcredit,loglist);
            List<ICreditManager> list = new List<ICreditManager>();
            list.Add(hcredit1);
            list.Add(needcredit);
            appman.uniform(list);
            
        }
    }
}
