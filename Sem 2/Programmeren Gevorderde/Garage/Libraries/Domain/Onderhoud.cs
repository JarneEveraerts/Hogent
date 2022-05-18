using System;

namespace Domain
{
	public abstract class Onderhoud
	{
        #region Properties
        public DateTime BeginDatum { get; set; }

		public DateTime EindDatum { get; set; }

		public string Nummerplaat { get; set; }
        #endregion

        #region Ctor
        public Onderhoud(DateTime begindatum, DateTime einddatum, string nummerplaat)
		{
			BeginDatum = begindatum;
			EindDatum = einddatum;
			Nummerplaat = nummerplaat;
		}
        #endregion

        #region Object inheritance
        public override string ToString()
		{
			return string.Format("nummerplaat {0} van {1} t.e.m. {2}", Nummerplaat, BeginDatum.ToShortDateString(), EindDatum.Date.ToShortDateString());
		}
        #endregion

        #region Methods
        public static int VergelijkOpNummerplaatDanOpBeginDatum(Onderhoud o1, Onderhoud o2)
        {
			int result = o1.Nummerplaat.CompareTo(o2.Nummerplaat);

			if (result != 0)
            {
				return result;
            }

			return o1.BeginDatum.CompareTo(o2.BeginDatum);
        }
		#endregion
	}
}