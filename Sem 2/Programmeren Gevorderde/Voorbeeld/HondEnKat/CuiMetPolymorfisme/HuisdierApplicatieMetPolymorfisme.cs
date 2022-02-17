using HondEnKat.Domein;
using System;

namespace HondEnKat.CuiMetPolymorfisme
{
	public class HuisdierApplicatieMetPolymorfisme
	{
		public static void Main(string[] args)
		{
			// <.>
			DomeinController dc = new();

			// <.>
			dc.InitialiseerDierenWinkel();

			// <.>
			string[] overzicht = dc.StelDierenVoor();
			foreach (string eenDier in overzicht)
			{
				Console.WriteLine(eenDier);
			}
			Console.WriteLine();

			// <.>
			Console.WriteLine(dc.GeefSpuitjes());
		}
	}

}
