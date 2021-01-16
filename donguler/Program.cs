using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "oop";
            string kurs2 = "java";
            string kurs3 = "c#";
            // Console.WriteLine(kurs1);
            // Console.WriteLine(kurs2);
            // Console.WriteLine(kurs3);
            //array

            string[] kurslar = new string[] { "oop" , "java" , "c#","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
               Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*************foreach***********");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
