using System;
using System.Collections.Generic;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Diclist = new Dictionary<int, string>();
            Diclist.Add(1, "yaso");
            Diclist.Add(7, "bilo");
            Diclist.Add(42,"ahmet");
            Console.WriteLine(Diclist[7]);
            MyDictionaryClass<int, string> myDic = new MyDictionaryClass<int, string>();
            myDic.add(1, "yaso");
            myDic.add(2, "bilal");
            myDic.add(5, "ahmet");
            myDic.getValue(5);
            myDic.getValue(9);

        }
    }
}
