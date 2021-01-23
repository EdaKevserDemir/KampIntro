using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //Method injection
        {
            //Başvuru bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();                       *************böyle yazarsak sadece konut kredisi başvurusu yapılabilir.Yanlış kodlamaa*********



            krediManager.Hesapla(); //başvuruyu kredi isminden bağımsız olarak alırız.
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
