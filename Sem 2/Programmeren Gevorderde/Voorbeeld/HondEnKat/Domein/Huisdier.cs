namespace HondEnKat.Domein
{
    public class Huisdier : System.Object // Je mag overerven van System.Object maar dat is overbodig
	{
        #region Properties
        public string Naam { get; set; }
        #endregion

        #region Ctor
        public Huisdier(string naam)
		{
			Naam = naam;
		}
        #endregion

        #region Methods
        public virtual bool LuisterNaarNaam(string naam)
		{
			return (naam.Equals(Naam));
		}
		public override string ToString()
		{
			return string.Format("{0} met naam {1}", this.GetType().Name, Naam);
		}

		public virtual string MaakGeluid()
		{
			return "!";
		}
		#endregion
	}

}
