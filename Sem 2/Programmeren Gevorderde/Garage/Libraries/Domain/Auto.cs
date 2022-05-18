using System;

namespace Domain
{

	public class Auto
	{
        #region Properties
        public string Merk { get; set; }

		public string Model { get; set; }

		public string Nummerplaat { get; set; }
        #endregion

        #region Ctor

        public Auto(string nummerplaat, string merk, string model)
		{
			Nummerplaat = nummerplaat;
			Merk = merk;
			Model = model;
		}
        #endregion

        #region Object inheritance
        public override bool Equals(object obj)
        {
            return obj is Auto auto &&
                   Nummerplaat == auto.Nummerplaat;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nummerplaat);
        }

        public override string ToString()
		{
			return string.Format("nummerplaat= {0}, merk= {1}, model = {2}", Nummerplaat, Merk, Model);
		}
        #endregion
    }

}