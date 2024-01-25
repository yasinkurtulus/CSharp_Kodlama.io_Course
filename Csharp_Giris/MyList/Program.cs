using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.showList();
            list.count();
            list.add(5);
            list.add(9);
            list.showList();
            Console.WriteLine(list.count());
            List<string> collectionList = new List<string>();
            collectionList.Add("hi");         
            
        }
    }
}
