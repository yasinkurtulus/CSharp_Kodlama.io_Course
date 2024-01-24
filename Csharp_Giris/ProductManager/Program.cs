using System;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            pr1.productName = "tshirt";
            pr1.productPrice = 20;
            pr1.productComm = "black tshirt";
            Product pr2 = new Product();
            pr2.productName = "table";
            pr2.productPrice = 100;
            Product[] products = new Product[] { pr1, pr2 };
            foreach (Product item in products)
            {
                Console.WriteLine(item.productName);
                Console.WriteLine(item.productPrice);
                Console.WriteLine(item.productComm);
            }
            Console.WriteLine("Hello World!");
            Product[] products2 = new Product[2];
            addProduct(pr2, products2, 0);
            addProduct(pr1, products2, 1);
        }
       
    
        public static void addProduct(Product prd,Product[] productArray,int i)
        {
            productArray[i] = prd;
            Console.WriteLine("the product has been added :"+prd.productName);
        }
    }
}
