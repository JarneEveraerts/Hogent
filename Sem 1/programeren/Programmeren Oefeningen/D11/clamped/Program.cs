using System;

namespace clamped
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voorbeeld GetClamped met min=3 en max=6");
            for (int i = 1; i <= 8; i++)
            {
                int clamped = GetClamped(3, i, 6);
                Console.WriteLine($"voor {i} geeft dit {clamped}");
            }
        }
        static int GetClamped(int min, int getal, int max)
        {
            int uitvoer;
            if (min <= getal && getal <= max)
            {
                uitvoer = getal;
            }
            else if (getal < min)
            {
                uitvoer = min;
            }
            else
            {
                uitvoer = max;
            }
            return uitvoer;
        }
    }
}
