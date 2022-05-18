using Domain;
using System;

namespace Cui
{
	public class GarageDBApp
	{
		private readonly DomeinController _dc;

		public GarageDBApp(DomeinController dc)
		{
		   _dc = dc;
		}

		public void BewerkDB()
		{
			try
			{
				Console.WriteLine("Overzicht van alle autos:");
				var count = 0;
				foreach (var carList in _dc.GeefAutos())
				{
					carList.ForEach(Console.WriteLine);
					count += carList.Count;
				}

				// Aanvullen database
				if (count == 0)
				{
					_dc.RegistreerAuto("123xyz", "Toyota", "Yaris");
					//_dc.RegistreerAuto("123xyz", "Toyota", "Yaris");
					_dc.RegistreerAuto("567xyz", "Renault", "Fluence");
					_dc.RegistreerAuto("456abc", "Opel", "Astra");
					_dc.RegistreerAuto("qwerty", "Toyota", "Avensis");
					_dc.RegistreerAuto("789cde", "Mercedes", "C-klasse Berline");
					_dc.RegistreerAuto("azerty", "BMW", "Berline");
					_dc.RegistreerAuto("ab12ab", "Opel", "Zafira");
					_dc.RegistreerAuto("xy12xy", "Peugeot", "308");
				}

				string infoAuto = _dc.GeefAuto("456abc");
				Console.WriteLine("Overzicht auto met nummerplaat '456abc':");
				Console.WriteLine(infoAuto);

				_dc.WijzigAuto("456abc", "Seat", "Alhambra");

				Console.WriteLine("Overzicht alle autos:");
				foreach (var carList in _dc.GeefAutos())
				{
					carList.ForEach(Console.WriteLine);
				}

				infoAuto = _dc.GeefAuto("456abc");
				Console.WriteLine("Overzicht auto met nummerplaat '456abc':");
				Console.WriteLine(infoAuto);

				_dc.VerwijderAuto("456abc");

				Console.WriteLine("Overzicht alle autos:");
				foreach (var carList in _dc.GeefAutos())
				{
					carList.ForEach(Console.WriteLine);
				}

				infoAuto = _dc.GeefAuto("456abc");
				Console.WriteLine("Overzicht auto met nummerplaat '456abc':");
				Console.WriteLine(infoAuto);
			}
			catch(Exception e)
            {
                Console.WriteLine(@"Probleem om op te vangen: " + e.Message);
				throw;
            }

		}
	}
}