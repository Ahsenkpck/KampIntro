using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Ahsen");


            Console.WriteLine(names.Length);
            names.Add("Şura");
            Console.WriteLine(names.Length);

            foreach (var name in names.Item)
            {
                Console.WriteLine(name);
            }
            //List<string> list = new List<string>();
            //list.Add("");
            //Console.WriteLine();

        }
    }
}
