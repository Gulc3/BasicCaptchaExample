using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, d3, d4;
            Random rn = new Random();

            d1 = rn.Next(0,10);
            d2 = rn.Next(0, 10);
            d3 = rn.Next(0, 10);
            d4 = rn.Next(0, 10);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            string[] karakterler = { "a", "A", "b ", "B", "c", "C", "d", "D", "e", "E" };
            Console.Write(d1 + karakterler[d2] + d3 + karakterler[d4] );


            Console.Read();

        }
    }
}