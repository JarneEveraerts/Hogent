using System;
using System.Threading;

namespace D06.twister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel begint over 3 seconden!");
            Thread.Sleep(3000);
            Console.WriteLine();

            Random rndm = new Random();

            while (true)
            {
                
                int lichaamsdeelGetal = rndm.Next(1, 5);
                int kleurGetal = rndm.Next(1, 5);

                string lichaamsdeel = "";
                string kleur = "";

                switch (lichaamsdeelGetal)
                {
                    case 1:
                        lichaamsdeel = "linkerhand";
                        break;

                    case 2:
                        lichaamsdeel = "rechterhand";
                        break;

                    case 3:
                        lichaamsdeel = "linkervoet";
                        break;

                    case 4:
                        lichaamsdeel = "rechtervoet";
                        break;
                }

                switch (kleurGetal)
                {
                    case 1:
                        kleur = "rood";
                        break;

                    case 2:
                        kleur = "groen";
                        break;

                    case 3:
                        kleur = "blauw";
                        break;

                    case 4:
                        kleur = "geel";
                        break;
                }

                Console.WriteLine($"{lichaamsdeel} op {kleur}");

                Thread.Sleep(7000);

            }


        }
    }
}
