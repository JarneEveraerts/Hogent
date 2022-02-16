using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=20;
            Console.WriteLine(i);
            do
            {
                
                i = i - 2;
                Console.WriteLine(i);
            } while (i>10);
        }
    }
}
