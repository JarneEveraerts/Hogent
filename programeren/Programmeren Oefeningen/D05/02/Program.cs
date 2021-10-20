using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, Getal=7;
            Console.WriteLine($"{i} X 7 = {Getal*i}");
            do
            {
                i++;
                Console.WriteLine($"{i} X 7 = {Getal * i}");
            } while (i<10);
        }
    }
}
