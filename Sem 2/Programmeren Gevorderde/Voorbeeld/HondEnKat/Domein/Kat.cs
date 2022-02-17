using System;

namespace HondEnKat.Domein
{
    public class Kat : Huisdier
	{
		public Kat(string naam) : base(naam)
		{
		}

		public override string MaakGeluid()
		{
			return "miauw";
		}

		/*
		public override bool LuisterNaarNaam(string naam)
		{
			Random r = new Random();
			if (r.Next(10) == 5)
			{
				return base.LuisterNaarNaam(naam);
			}
			return false;
		}
		*/

		public string Spin()
		{
			return base.Naam + " spint";
		}
	}
}
