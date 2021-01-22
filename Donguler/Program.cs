using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştime kampı";
            string kurs2 = "temel kurs";
            string kurs3 = "java";

            //Array-Diziler

            string[] kurslar = new string[] { "yazılım geliştime kampı","temel kurs", "java","python","c#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfasonu");
            Console.ReadLine();
        }
    }
}
