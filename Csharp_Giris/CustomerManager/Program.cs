using System;

namespace CustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("how many customer will you add?");
            int numberofCs = Convert.ToInt32(Console.ReadLine());
            Customer[] customers = new Customer[numberofCs];

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("input "+i+". customers name");
                string csname = Console.ReadLine();
                Console.WriteLine("input " + i + ". customers id");
                int csid = Convert.ToInt32(Console.ReadLine());
                Customer customer = new Customer();
                customer.name = csname;
                customer.id = csid;
                customerAdd(customer, customers,i);
              
            }
            showAllCustomers(customers);
            



        }
        public static void customerAdd(Customer cs,Customer[] array,int i)
        {
            array[i] = cs;
        }
        public static void changename(Customer cs,string name)
        {
            cs.name = name;
        }
        public static void showAllCustomers(Customer[] customers)
        {
            foreach (Customer item in customers)
            {
                Console.WriteLine(item.name);
            }
        }
     
    }
   
}
