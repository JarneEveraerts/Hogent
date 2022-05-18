using Domain.Contracts;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Garage
	{
        #region Properties
        private IAutoRepository _autoRepo;
		private IOnderhoudRepository _onderhoudRepo;

		private Dictionary<string, List<string>> _merkenEnModellen = new()
		{
			{ "Toyota", new List<String>() {"Yaris", "Avensis"} },
			{ "Renault", new List<String>() {"Fluence"} },
			{ "Mercedes", new List<String>() {"C-Klasse Berline", "A-Klasse Berline"} },
			{ "Opel", new List<String>() {"Zafira", "Astra"} },
			{ "BMW", new List<String>() {"320", "521"} },
			{ "Peugeot", new List<String>() {"308", "508"} }
		};
        #endregion

        #region Ctor
        public Garage(IAutoRepository autoRepo, IOnderhoudRepository onderhoudRepo)
		{
			_autoRepo = autoRepo;
			_onderhoudRepo = onderhoudRepo;
		}
        #endregion

        #region Methods
        private void ControleerAutoGegevens(string nummerplaat, string merk, string model)
        {
			if (String.IsNullOrWhiteSpace(nummerplaat))
			{
				throw new GarageException("Nummerplaat is ongeldig.");
			}

			if (String.IsNullOrWhiteSpace(merk) || !_merkenEnModellen.ContainsKey(merk))
			{
				throw new GarageException("Merk is ongeldig!");
			}

			if (String.IsNullOrWhiteSpace(model) || !_merkenEnModellen[merk].Contains(model))
			{
				throw new GarageException("Model is ongeldig!");
			}
		}

		public void RegistreerAuto(string nummerplaat, string merk, string model )
        {
			ControleerAutoGegevens(nummerplaat, merk, model);

			if (GeefAuto(nummerplaat) is not null)
            {
				// Oops, de nummerplaat bestaat reeds in de DB
				throw new RegistreerException("Deze nummerplaat is reeds geregistreerd.");
            }

			_autoRepo.Insert(new Auto(nummerplaat, merk, model));
        }

		public List<Auto> GeefAutos()
        {
			return _autoRepo.Get();
        }

		public Auto GeefAuto(string nummerplaat)
        {
			return _autoRepo.Read(nummerplaat);
        }

		public void WijzigAuto(string nummerplaat, string merk, string model )
        {
			ControleerAutoGegevens(nummerplaat, merk, model);

			_autoRepo.Update(new Auto(nummerplaat, merk, model));
        }

        public void VerwijderAuto(string nummerplaat)
		{
			if (String.IsNullOrWhiteSpace(nummerplaat) || GeefAuto(nummerplaat) == null)
				throw new GarageException("Nummerplaat is ongeldig of niet aanwezig in de DB!");

			_autoRepo.Delete(nummerplaat);
		}

		public List<string> GeefMogelijkeMerken()
        {
			return new List<string>(_merkenEnModellen.Keys);
        }

		public List<string> GeefMogelijkeModellen(string merk)
        {
			if (_merkenEnModellen.ContainsKey(merk))
            {
				return _merkenEnModellen[merk];
            }
            else
            {
				throw new ArgumentException("Ongekend merk.");
            }
        }
		#endregion
	}
}