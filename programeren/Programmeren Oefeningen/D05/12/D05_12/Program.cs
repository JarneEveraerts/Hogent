using System;

namespace D05_12
{
    class Program
    {
        static void Main(string[] args)
        {
			int getal1;
			Console.Write("Getal 1?: ");
			string getalAlsTekst = Console.ReadLine();
			bool invoerOk = int.TryParse(getalAlsTekst, out getal1);
			while (!invoerOk)
			{
				Console.Write("Gelieve een geheel getal in te voeren, getal 1?: ");
				getalAlsTekst = Console.ReadLine();
				invoerOk = int.TryParse(getalAlsTekst, out getal1);
			}

			int getal2;
			Console.Write("Getal 2?: ");
			getalAlsTekst = Console.ReadLine();
			invoerOk = int.TryParse(getalAlsTekst, out getal2);
			while (!invoerOk)
			{
				Console.Write("Gelieve een geheel getal in te voeren, getal 2?: ");
				getalAlsTekst = Console.ReadLine();
				invoerOk = int.TryParse(getalAlsTekst, out getal2);
			}

			Console.Write("Reeks van klein naar groot: ");

			int kleinste;
			int grootste;
			if (getal1 <= getal2)
			{
				kleinste = getal1;
				grootste = getal2;
			}
			else
			{
				kleinste = getal2;
				grootste = getal1;
			}

			int getalInReeks = kleinste;
			while (getalInReeks <= grootste)
			{
				Console.Write($"{getalInReeks} ");
				getalInReeks++;
			}
		}
    }
}
