using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k+c toplu comment alma
            //geri alma ctrl+k+u

            //string[] names1 = new string[] { "Ahsen", "Şura", "Yuşa","Ali" };
            //Console.WriteLine(names1[0]);
            //Console.WriteLine(names1[1]);
            //Console.WriteLine(names1[2]);

            //names1=new string [4];
            //names1[3] = "Ali";
            //Console.WriteLine(names1[3]);

            List<string> names2 = new List<string> {"Ahsen","Şura","Yuşa","Mehmet" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Mustafa");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
