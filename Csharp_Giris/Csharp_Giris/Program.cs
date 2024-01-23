using System;

namespace Csharp_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string kurs1 = "java kursu";
            string kurs2 = "phyton kursu";
            string kurs3 = "C kursu";
            string kurs4 = "C # kursu";
            string[] kurslar = new string[4];
            kurslar[0] = kurs1;
            kurslar[1] = kurs2;
            kurslar[2] = kurs3;
            kurslar[3] = kurs4;
            foreach (string i in kurslar)
            {
                Console.WriteLine(i);
            }

        }
    }
}
