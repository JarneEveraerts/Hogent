using Domain.Contracts;
using System.Collections.Generic;
using System.Linq;


// NADEEL: "God" anti-pattern

namespace Domain
{

    public class DomeinController
	{
        #region Properties
        private Garage _garage;
        #endregion

        #region Ctor
        public DomeinController(IAutoRepository autoRepo, IOnderhoudRepository onderhoudRepo)
		{
			_garage = new Garage(autoRepo, onderhoudRepo);
		}
        #endregion

        #region Methods

        public void RegistreerAuto(string nummerplaat, string merk, string model )
		{
			_garage.RegistreerAuto(nummerplaat, merk, model);
		}

		public List<List<string>> GeefAutos()
        {
			return _garage.GeefAutos()
				.Select(auto => new List<string>() {auto.Nummerplaat, auto.Merk, auto.Model})
				.ToList();
        }

		public string GeefAuto(string nummerplaat)
		{
			return _garage.GeefAuto(nummerplaat).ToString();
		}

		public void WijzigAuto(string nummerplaat, string merk, string model)
		{
			_garage.WijzigAuto(nummerplaat, merk, model);
		}

		public void VerwijderAuto(string nummerplaat)
		{
			_garage.VerwijderAuto(nummerplaat);
		}

		public List<string> GeefMogelijkeMerken()
		{
			return _garage.GeefMogelijkeMerken();
		}

		public List<string> GeefMogelijkeModellen(string merk)
        {
			return _garage.GeefMogelijkeModellen(merk);
        }
		#endregion
	}
}