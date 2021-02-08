using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1);//number1=30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 888;
            Console.WriteLine(numbers1[0]);

        }
        //Value Types-->int,double,decimal,float,bool
        //Reference Types-->array,interface,class
    }
}
