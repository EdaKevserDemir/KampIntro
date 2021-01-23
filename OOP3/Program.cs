using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerservice = new FileLoggerService();




            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager,tasitKrediManager};

          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);




            Console.ReadLine();
        }
    }
}
