using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "ekşi";


            Product product2 = new Product();
            product2.Adi= "Çilek";
            product2.Fiyat = 13;
            product2.Aciklama = "tatlı";

            Product[] products = new Product[] { product1,product2};

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " " + product.Fiyat + " " + product.Aciklama);
            }
            Console.WriteLine("--------------Metotlar---------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);

            sepetManager.Add2("elma", "sarı", 10);
            sepetManager.Add2("armut", "bal", 5);



            Console.ReadLine();
        }
    }
}
