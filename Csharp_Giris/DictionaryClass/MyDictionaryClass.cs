using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClass
{
    class MyDictionaryClass<K,V>
    {
        K[] array1;
        V[] array2;
        public MyDictionaryClass()
        {
            array1 = new K[0];
            array2 = new V[0];
        }
        public void add(K key, V value) 
        {
            K[] temp1;
            V[] temp2;
            temp1 = array1;
            temp2 = array2;
            array1 = new K[array1.Length + 1];
            array2 = new V[array1.Length + 1];
            for (int i = 0; i < temp1.Length; i++)
            {
                array1[i] = temp1[i];
            }
            array1[array1.Length - 1] = key;
            for (int i = 0; i < temp2.Length; i++)
            {
                array2[i] = temp2[i];
            }
            array2[array2.Length - 1] = value;
        }
        public void getValue(K key)
        {
           
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Equals(key))
                {
                    Console.WriteLine(array2[i]);
                }
                
            }
        } 
    }
}
