namespace ZonderOvererving
{
    
    //tag::KatZonderPackage[]
    public class Kat
	{
		

		public Kat(string naam)
		{
			Naam = naam;
		}
		public string Naam { get; set; }

		public string MaakGeluid()
		{
			return "miauw";
		}
		public bool LuisterNaarNaam(string naam)
		{
			return naam.Equals(Naam);
		}
		public string Spin()
		{
			return Naam + " spint";
		}
		public override string ToString() // <.>
		{
			return string.Format("{0} met naam {1}", this.GetType().Name, Naam);
		}
	}
	//end::KatZonderPackage[]

}
