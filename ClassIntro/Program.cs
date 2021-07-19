using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "asdas";
            kurs1.KursAdi = "php";
            kurs1.IzlenmeOranı = 1000;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "dasdas";
            kurs2.IzlenmeOranı = 100;
            kurs2.KursAdi = "html";

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOranı);


            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
