using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyList<T>
    {
        T[] array;
        public MyList()
        {
            array = new T[0];
        }
        public void add(T item)
        {
            T[] tempArray = array;

            array = new T[array.Length + 1];
            if (tempArray.Length!=0)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[i] = tempArray[i];
                }
        
            }
            array[array.Length - 1] = item;

        }
        public void showList()
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
        public int count (){
            return array.Length;

            }
        
    }
}
