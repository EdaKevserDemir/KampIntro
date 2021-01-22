using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type-safety
            //Dont repeat yourself

            //değer tutucu-alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapildiMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine(" azalış");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
                Console.WriteLine("Değişmedi");

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();

        }
    }
}
