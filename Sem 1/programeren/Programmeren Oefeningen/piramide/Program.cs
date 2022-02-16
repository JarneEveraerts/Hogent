using System;

namespace piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hoogte,i=0;
            string Uitvoer="1",Invoer;
            Console.WriteLine("geef ke hoogte");
            Invoer = Console.ReadLine();
            bool Convers = int.TryParse(Invoer, out Hoogte);
            while (i < Hoogte)
            {
                Console.WriteLine(Uitvoer);
                if (Convers)
                {
                    for (i =0; i < Hoogte; i++)
                    {
                        if (Uitvoer.Substring(0, 1) == "1")
                        {
                            Uitvoer ="0" + Uitvoer ;
                            Console.WriteLine(Uitvoer);
                        }
                        else
                        {
                            Uitvoer = "1" + Uitvoer;
                            Console.WriteLine(Uitvoer);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("geef ke hoogte");
                    Invoer = Console.ReadLine();
                    Convers = int.TryParse(Invoer, out Hoogte);
                }
            }
        }
    }
}
