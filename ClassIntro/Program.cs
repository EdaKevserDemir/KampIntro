using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.EgitmenAdi = "Eda";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.EgitmenAdi = "Kevser";
            kurs3.IzlenmeOrani = 80;


            //  Console.WriteLine(kurs1.KursAdi+ " " +kurs1.EgitmenAdi );

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" " + kurs.EgitmenAdi );
            }


            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string EgitmenAdi { get; set; }

        public int IzlenmeOrani { get; set; }


    }

}
