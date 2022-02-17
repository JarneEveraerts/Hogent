namespace HondEnKat.Domein
{
    public class Hond : Huisdier
	{
		public Hond(string naam) : base(naam)
		{
		}

		public override string MaakGeluid()
		{
			string geluid = "waf waf";
			geluid += base.MaakGeluid();
			return geluid;
		}

		public string Kwispel()
		{
			return "kwispel-kwispel-kwispel";
		}
	}

}
