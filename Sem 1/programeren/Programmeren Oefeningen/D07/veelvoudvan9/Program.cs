using System;

namespace veelvoudvan9
{
    class Program
    {
        static void Main(string[] args)
        {
            double uitkomst;
            for (int i = 1; i < 16; i+=2)
            {
                uitkomst = i * 9;
                Console.WriteLine($"{i} X 9 = {uitkomst}");
            }
        }
    }
}
