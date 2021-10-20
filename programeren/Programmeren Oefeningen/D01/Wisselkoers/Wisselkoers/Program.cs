using System;

namespace Wisselkoers
{
    class Program
    {
        static void Main(string[] args)
        {
            double euroBedrag = 105.4;
            double poundBedrag = euroBedrag * 0.89;
            Console.Write(euroBedrag);
            Console.Write("EUR = ");
            Console.Write(poundBedrag);
            Console.Write("GPB");

        }
    }
}
