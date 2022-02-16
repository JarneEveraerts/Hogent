using System;

namespace Twister
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "rood", "groen", "blauw", "geel" };
            string[] lichaamsdelen = { "linkerhand", "rechterhand", "linkervoet", "rechtervoet" };
            Random Rand = new Random();
            Console.WriteLine("maakt ulder gereed e");
            System.Threading.Thread.Sleep(3000);
            while (true)
            {
                Console.WriteLine($"{lichaamsdelen[Rand.Next(0, 3)]} op {kleuren[Rand.Next(0, 3)]}");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
