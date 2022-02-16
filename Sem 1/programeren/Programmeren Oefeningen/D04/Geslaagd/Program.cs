using System;

namespace Geslaagdµ
{
    class Program
    {
        static void Main(string[] args)
        {
            double Vak1, Vak2, Vak3, Totaal;
            int I=0;
            Console.WriteLine("Geef vak 1 in");
            Vak1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geef vak 2 in");
            Vak2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geef vak 3 in");
            Vak3 = double.Parse(Console.ReadLine());
            Totaal = Vak1 + Vak2 + Vak3;
            if (Vak1 < 4 || Vak2 < 4 || Vak3 < 4)
            {
                I++;
            }

            if (Vak1>4&&Vak2>4&&Vak3>44)
            {
                Console.WriteLine("u bent geslaagd");
            }
            else if (Totaal > 17 && I==0)
            {
                Console.WriteLine("u bent geslaagd");
            }
            else
            {
                Console.WriteLine("u bent gefaald");
            }
        }
    }
}
