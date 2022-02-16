using System;

namespace Waarde_wissel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5,b = 13,c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
