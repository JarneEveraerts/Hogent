using System;

namespace Persecondewijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            int Uur, Minuut, Second, Ingave;
            Console.WriteLine("geef uw aantal seconden in");
            Ingave = Convert.ToInt16(Console.ReadLine());
            Uur = Ingave / 3600;
            Ingave = Ingave % 3600;
            Minuut = Ingave / 60;
            Second = Ingave % 60;
            Console.WriteLine($"dit is {Uur}:{Minuut}:{Second}.");


        }
    }
}
