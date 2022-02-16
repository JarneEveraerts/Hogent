using System;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een geheel getal in");
            double Getal = Convert.ToDouble(Console.ReadLine());
            if ((Getal % 2 == 0))
            {
                Console.WriteLine("uw getal is even");
            }
            else
            {
                Console.WriteLine("uw getal is oneven");
            }
        }
    }
}
