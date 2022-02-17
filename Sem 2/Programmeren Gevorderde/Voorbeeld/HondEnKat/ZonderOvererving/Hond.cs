using System;

namespace ZonderOvererving
{
    //tag::HondZonderPackage[]
    public class Hond
	{
		
		public Hond(string naam)
		{
			Naam = naam;
		}
		public string Naam { get; set; }

		public string MaakGeluid()
		{
			return "waf waf";
		}
		public bool LuisterNaarNaam(string naam)
		{
			return naam.Equals(Naam);
		}
		public string Kwispel()
		{
			return "kwispel-kwispel-kwispel";
		}
		public override string ToString() // <.>
		{
			return string.Format("{0} met naam {1}", this.GetType().Name, Naam);
		}
	}
	//end::HondZonderPackage[]

}
