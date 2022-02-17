using HondEnKat.Domein;
using System;
using System.Collections.Generic;

namespace HondEnKat.Cui
{
    public class HuisdierApplicatieMetOvererving
	{
		public static void Main(string[] args)
		{
			Huisdier hd = new("Nijntje");
			Kat k = new("Musti");
			Hond h = new("Rintje");

			// <.>
			Console.WriteLine("Dit zijn de huisdieren:");
			Console.WriteLine(hd);
			Console.WriteLine(k);
			Console.WriteLine(h);
			Console.WriteLine();

			// <.>
			Console.WriteLine("Ze kunnen ook allemaal een soort van geluid maken...");
			Console.Write("{0} maakt geluid {1}\n", hd.Naam, hd.MaakGeluid());
			Console.Write("{0} maakt geluid {1}\n", k.Naam, k.MaakGeluid());
			Console.Write("{0} maakt geluid {1}\n", h.Naam, h.MaakGeluid());
			Console.WriteLine();

			// <.>
			Console.WriteLine("En de kat en de hond kunnen tenslotte nog iets bijzonders:");
			Console.Write("Het bijzondere wat een {0} kan, is {1}\n", k.GetType().Name, k.Spin());
			Console.Write("Het bijzondere wat een {0} kan, is {1}\n", h.GetType().Name, h.Kwispel());

			/*
			List<Huisdier> dieren = new();
			dieren.Add(hd);
			dieren.Add(k);
			dieren.Add(h);
			foreach(var dier in dieren)
            {
				Console.WriteLine(dier.MaakGeluid());
				// Hoe wil ik kunnen kwispelen? Ik moet weten dat het om een hond gaat en van de hond in code ook een hond maken
				if(dier is Hond)
                {
					var hond = (Hond)dier; // downcast
					hond.Kwispel();
                }
            }
			*/
		}
	}
}
