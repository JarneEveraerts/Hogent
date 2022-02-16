using System;

namespace som
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef cijfer 1");
            int Cijfer1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("geef cijfer 2");
            int Cijfer2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Cijfer1 + "+" + Cijfer2 + "=" + Convert.ToString(Cijfer1 + Cijfer2));
        }
    }
}
