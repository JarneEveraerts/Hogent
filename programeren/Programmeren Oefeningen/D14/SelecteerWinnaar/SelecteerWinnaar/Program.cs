using System;

namespace SelecteerWinnaar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Persoon[] personen = new Persoon[5];
            Persoon persoon = new Persoon();
            Persoon winnaar = new Persoon();
            string input = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("geef keer een naamke");
                input = Console.ReadLine();

                personen[i] = new Persoon();
                personen[i].SetNaam(input);
            }
            winnaar = SelecteerWinnaar(personen);
            Console.WriteLine($"de winnaar is {winnaar.GetNaam()}");
        }

        private static Persoon SelecteerWinnaar(Persoon[] personen)
        {
            Random rand = new Random();
            int random = rand.Next(0, 5);
            Persoon persoon = personen[random];
            return persoon;
        }
    }
}