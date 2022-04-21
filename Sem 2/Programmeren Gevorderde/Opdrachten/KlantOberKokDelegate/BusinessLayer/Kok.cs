// HOGENT

namespace Domain
{
    public class Kok // consumer van een event: abonneert zich op een event, namelijk op die van het bestellingssysteem
    {
        #region Properties

        public string Naam { get; set; }

        // Consumer:
        private BestellingsSysteem _bestellingsSysteem;
        public BestellingsSysteem BestellingsSysteem
        {
            get
            {
                return _bestellingsSysteem;
            }
            set
            {
                // preconditie: ik zorg ervoor dat ik me maar eenmaal inschrijf op een event
                if (_bestellingsSysteem != null) 
                    _bestellingsSysteem.BestellingEvent -= OnBestelling; // uitschrijven indien nodig
                _bestellingsSysteem = value;
                _bestellingsSysteem.BestellingEvent += OnBestelling; // als de bestelling event opgeroepen wordt, dan wordt method BestellingOntvangen
            }
        }

        // Publisher:
        public Bel Bel { get; set; }

        #endregion

        #region Ctor
        public Kok(string naam)
        {
            Naam = naam;
        }
        #endregion

        #region Method
        public void OnBestelling(string klant, string product)
        {
            if (string.IsNullOrEmpty(klant) || string.IsNullOrEmpty(product)) return; // preconditie

            System.Diagnostics.Debug.WriteLine(product + " in voorbereiding");
            System.Threading.Thread.Sleep(5000); // ik slaap 5 seconden: 5 keer 1000 milliseconden
            // Event:
            // ------
            Bel.Ring(klant, product); // losse koppeling: kok weet niet dat het de ober is die op het event geabonneerd is
        }
        #endregion
    }
}
