using System;

namespace toonkader
{
    class Program
    {
        static void Main(string[] args)
        {
            ToonInKader("Hallo");
        }
        static void ToonInKader(string woord)
        {
            int lengte = woord.Length + 2;
            string lijn = "";
            for (int i = 0; i < lengte; i++)
            {
                lijn += "*";
            }
            Console.WriteLine(lijn);
            Console.WriteLine($"*{woord}*");
            Console.WriteLine(lijn);
        }

    }
}
