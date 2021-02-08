using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Ahsen";
            int yas = 20;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "Java Script Kursu";
            kurs1.Egitmen="Ahsen Kıpçak";
            kurs1.IzlenmeOrani = 85;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java Kursu";
            kurs2.Egitmen = "Şura Kıpçak";
            kurs2.IzlenmeOrani = 90;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C# Kursu";
            kurs3.Egitmen = "Yuşa Kıpçak";
            kurs3.IzlenmeOrani = 90;

            Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);
            Console.WriteLine(" ");
            Kurs[] kurslar = new Kurs[]{kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            Console.WriteLine("Program sonu..");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
