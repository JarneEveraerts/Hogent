namespace HondEnKat.Domein
{
    public class Duif : Huisdier
	{
		private readonly long _ringnr;

		public Duif(string naam, long ringnr) : base(naam)
		{
			ControleerRingnr(ringnr);
			this._ringnr = ringnr;
		}

		public override string MaakGeluid()
		{
			return "roekoekoe";
		}

		public long Ringnr
		{
			get
			{
				return _ringnr;
			}
		}

		private void ControleerRingnr(long ringnr)
		{
			if (ringnr <= 19000000000L || ringnr > 99999999999L)
			{
				throw new System.ArgumentException("Geen geldig ringnummer");
			}
		}

		public override string ToString() // <.>
		{
			return string.Format("{0} met ringnummer {1:D}", base.ToString(), _ringnr);
		}
	}
}
