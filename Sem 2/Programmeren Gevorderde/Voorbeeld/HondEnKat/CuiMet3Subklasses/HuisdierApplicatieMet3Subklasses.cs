using HondEnKat.Domein;

namespace HondEnKat.CuiMet3Subklasses
{
    using System;

	public class HuisdierApplicatieMet3Subklasses
	{
		public static void Main(string[] args)
		{
			HuisdierApplicatieMet3Subklasses app = new HuisdierApplicatieMet3Subklasses();

			Huisdier hd = new("Nijntje");
			Kat k = new("Musti");
			Hond h = new("Rintje");
			Duif d = new("Wittekop", 20201234567L); // <.>

			Console.WriteLine("Dit zijn de huisdieren:");
			Console.WriteLine(hd);
			Console.WriteLine(k);
			Console.WriteLine(h);
			Console.WriteLine(d); // <.>
			Console.WriteLine();
		}
	}
}
