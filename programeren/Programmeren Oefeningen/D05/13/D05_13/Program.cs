using System;

namespace D05_13
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Aantal liedjes in de playlist?: ");
			string aantalLiedjesAlsTekst = Console.ReadLine();

			double aantalLiedjes;
			bool invoerOk = double.TryParse(aantalLiedjesAlsTekst, out aantalLiedjes);

			if (invoerOk && aantalLiedjes >= 1)
			{
				double faculteit;

				faculteit = 1;
				double factor = 2;
				while (factor <= aantalLiedjes)
				{
					faculteit = faculteit * factor;
					factor = factor + 1;
				}

				string meervoud = "";
				if (faculteit > 1)
				{
					meervoud = "s";
				}
				Console.Write($"{aantalLiedjes} liedje{meervoud} kan je in {faculteit} verschillende volgorde{meervoud} in een playlist plaatsen.");
			}
		}
        }
    } 


