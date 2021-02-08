using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Nitelikli Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "İleri Seviye Java Kursu";
            string kurs3 = "Java Script";
            string kurs4 = "CSS";

            //array - dizi
            string[] kurslar = new string[]{
            "Nitelikli Yazılım Geliştirici Yetiştirme Kampı",
            "İleri Seviye Java Kursu",
            "Java Script",
            "HTML",
            "CSS"};

            for (int i = 0; i < kurslar.Length; i++)              
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti..");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu... ");
        }
    }
}
    

