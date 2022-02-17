using System.Collections.Generic;

namespace HondEnKat.Domein
{
    public class DierenWinkel
	{
		//tag::DierenWinkelAttribuut[]
		private IList<Huisdier> _lijstHuisdieren;
		//end::DierenWinkelAttribuut[]

		//tag::DierenWinkelConstructor[]
		public DierenWinkel()
		{
			_lijstHuisdieren = new List<Huisdier>();
		}
		//end::DierenWinkelConstructor[]

		//tag::DierenWinkelStelDierenVoor[]
		public string[] StelDierenVoor()
		{
			string[] voorstelling = new string[_lijstHuisdieren.Count];
			int index = 0;
			foreach (Huisdier dier in _lijstHuisdieren)
			{
				voorstelling[index] = string.Format("{0} zegt {1}", dier.ToString(), dier.MaakGeluid());
				index++;
			}
			return voorstelling;
		}
		//end::DierenWinkelStelDierenVoor[]

		//tag::DierenWinkelGeefSpuitje[]
		public string GeefSpuitje(Huisdier dier)
		{
			return string.Format("Awwwwww... dat doet pijn! {0}", dier.MaakGeluid());
		}
		//end::DierenWinkelGeefSpuitje[]

		//tag::DierenWinkelVoegHuisdierToe[]
		public void VoegHuisdierToe(Huisdier dier)
		{
			if (dier != null)
			{
				_lijstHuisdieren.Add(dier);
			}
		}
		//end::DierenWinkelVoegHuisdierToe[]

		//tag::DierenWinkelGeefDierOpIndex[]
		public Huisdier GeefDierOpIndex(int index)
		{
			return _lijstHuisdieren[index];
		}
		//end::DierenWinkelGeefDierOpIndex[]

		//tag::DierenWinkelGeefAantalDieren[]
		public int GeefAantalDieren()
		{
			return _lijstHuisdieren.Count;
		}
		//end::DierenWinkelGeefAantalDieren[]
	}

}
