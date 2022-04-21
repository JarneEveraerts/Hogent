// HOGENT
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Ober
    {
        #region Properties
        private readonly List<Klant> _klanten = new(); // C# 9.0: je kan enkel new() gebruiken, in plaats van new List<Klant>();

        public string Naam { get; set; }

        public BestellingsSysteem BestellingsSysteem { get; set; }

        // Event:
        // ------        
        private Bel _bel;

        public Bel Bel
        {
            get
            {
                return this._bel;
            }

            set
            {
                if (this._bel != null) this._bel.RingEvent -= this.OnRing; // goed zien dat je je niet op 2 belletjes of 2 keer op hetzelfde belletje inschrijft!!
                this._bel = value;
                this._bel.RingEvent += this.OnRing;
            }
        }

        #endregion

        #region Ctor
        public Ober(string name)
        {
            this.Naam = name;
        }
        #endregion

        #region Methods
        public void BrengBestelling(Klant klant, string product)
        {
            if (klant == null || string.IsNullOrEmpty(product)) return; // preconditie

            if (!_klanten.Contains(klant))
                _klanten.Add(klant);

            BestellingsSysteem.GeefBestellingIn(klant.Naam, product);
        }

        private void OnRing(string klant, string product)
        {
            // LINQ: sneak preview; vergelijk SQL, declaratief - niet iteratief
            var k = this._klanten.Where(k => k.Naam == klant).FirstOrDefault(); // EERSTE OF null want klant is object (default is dan null)
            if (k == null) return;

            k.Betaal(product);
            k.Consumeer(product);
        }
        #endregion
    }
}
