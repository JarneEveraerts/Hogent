using System;

namespace GroterDan
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, Getal, Middelste=0, Kleinste=0, Grootste=0;
            Console.WriteLine("geef een getal in");
            Getal = int.Parse(Console.ReadLine());
            Grootste = Getal;
            Kleinste = Getal;
            while (i < 3)
            {
                Console.WriteLine("geef een getal in");
                Getal = int.Parse(Console.ReadLine());
                if (Getal < Kleinste)
                {
                    Middelste = Kleinste;
                    Kleinste = Getal;
                }
                else if (Getal > Grootste)
                {
                    Middelste = Grootste;
                    Grootste = Getal;
                }
                i++;
                
            }
            Console.WriteLine($"grootste= {Grootste}, Kleinste= {Kleinste}, Middelste={Middelste}");
            
            
        }
    }
}
