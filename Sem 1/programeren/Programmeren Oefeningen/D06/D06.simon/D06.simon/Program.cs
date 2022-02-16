using System;
using System.Threading;

namespace D06.simon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start binnen 3 seconden!");
            Thread.Sleep(3000);
            Console.Clear();

            Random rndm = new Random();

            bool correct = true;

            int vorigGetal = 0;
            int teller = 0;



            while (correct != false)
            {
                int rndmgetal = rndm.Next(1, 10);

                

                string vorigGetalString = Convert.ToString(vorigGetal);
                string rndmgetalString = Convert.ToString(rndmgetal);

                string getalString = string.Concat(vorigGetalString, rndmgetalString);

                int getal = Convert.ToInt32(getalString);


                Console.WriteLine("U hebt 2 seconden om deze code te onthouden:");
                Console.WriteLine(getal);
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Geef de code:");
                int invoer = Convert.ToInt32(Console.ReadLine());

                if (invoer == getal)
                {
                    Console.WriteLine();
                    Console.WriteLine("Correct!");

                    vorigGetal = getal;
                    rndmgetal = rndm.Next(1, 10);


                    teller++;
                    correct = true;
                    
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (invoer != rndmgetal)
                {
                    Console.WriteLine();
                    Console.WriteLine("Helaas, de code was:");
                    Console.WriteLine(getal);

                    Console.WriteLine();
                    Console.WriteLine($"Je had het getal {teller} keer goed onthouden!");

                    Console.WriteLine();
                    Console.WriteLine("Druk op een toets om te sluiten...");

                    correct = false;
                }
            }

            Console.ReadKey();
            



        }
    }
}
