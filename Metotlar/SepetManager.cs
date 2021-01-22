using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager //Operasyon tutuluyor
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler "+ product.Adi + " Sepete eklendi!!");

        }

        public void Add2(string urunAdi,string aciklama,int fiyat)
        {
            Console.WriteLine("Tebrikler " +urunAdi + " Sepete eklendi!!");

        }


    }
}
