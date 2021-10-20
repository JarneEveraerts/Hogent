using System;

namespace Imperial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double Feet = 30.48;
            const double Inches = 2.54;
            Console.Write("Geef het aantal feet : ");
            string aantalFeetAlsTekst = Console.ReadLine();
            double aantalFeet = double.Parse(aantalFeetAlsTekst);
            Console.Write("Geef het aantal inches : ");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);
            double aantalFeetInCm = aantalFeet * Feet;
            double aantalInchesInCm = aantalInches * Inches;
            double totaalInCm = aantalFeetInCm + aantalInchesInCm;
            Console.WriteLine($"Dat is {totaalInCm}cm.");
        }
    }
}