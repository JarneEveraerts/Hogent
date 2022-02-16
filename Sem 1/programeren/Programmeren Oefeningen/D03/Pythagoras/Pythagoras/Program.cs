using System;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double Basis, Breedte, Schuin;
            Console.WriteLine("Geef de basis (cm) in");
            Basis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de breedte (cm) in");
            Breedte = Convert.ToDouble(Console.ReadLine());
            Schuin = Math.Sqrt((Math.Pow(Basis, 2) + Math.Pow(Breedte, 2)));
            Console.WriteLine($"de schuine zijde is {Schuin}cm");
        }
    }
}
