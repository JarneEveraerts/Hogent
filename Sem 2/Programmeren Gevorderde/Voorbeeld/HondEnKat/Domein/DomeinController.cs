using System;

namespace HondEnKat.Domein
{
    public class DomeinController
	{
		private DierenWinkel _winkel;

		public DomeinController() // <.>
		{
			_winkel = new DierenWinkel();
		}

		public void InitialiseerDierenWinkel() // <.>
		{
			Duif duif1 = new("Blauwe geschelpte", 20180000001L);
			_winkel.VoegHuisdierToe(duif1);
			Kat kat1 = new("Minoe");
			_winkel.VoegHuisdierToe(kat1);
			Hond hond1 = new("Rex");
			_winkel.VoegHuisdierToe(hond1);
			Hond hond2 = new("Lassie");
			_winkel.VoegHuisdierToe(hond2);
			Duif duif2 = new("Witoog", 20199876543L);
			_winkel.VoegHuisdierToe(duif2);
			Kat kat2 = new("Garfield");
			_winkel.VoegHuisdierToe(kat2);
		}

		public string[] StelDierenVoor() // <.>
		{
			return _winkel.StelDierenVoor();
		}

		public string GeefSpuitjes() // <.>
		{
			Random random = new();
			string uitvoer = "";
			for (int i = 0; i < 3; i++)
			{
				int aantalDieren = _winkel.GeefAantalDieren();
				int randomIndex = random.Next(aantalDieren);
				Huisdier patient = _winkel.GeefDierOpIndex(randomIndex);
				uitvoer += string.Format("{0}\n", _winkel.GeefSpuitje(patient));
			}
			return uitvoer;
		}
	}

}
