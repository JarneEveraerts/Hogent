using Domain;
using System;

namespace KlantOberKok
{
    class Program
    {
        static void Main(string[] args)
        {
            var klant1 = new Klant("Piet");
            var klant2 = new Klant("Jef");

            var bestellingsSysteem = new BestellingsSysteem(); // vb iPAD
            var bel = new Bel();  
            
            var ober = new Ober("Jan")
            {
                BestellingsSysteem = bestellingsSysteem, // publisher: waarop hij moet ingeven
                Bel = bel // consumer: waarnaar hij moet luisteren
            };
            // kok en ober weten niet van elkaar!
            var kok = new Kok("Marie")
            {
                Bel = bel, // publisher: waarop zij moet duwen - de publisher, de oproeper
                BestellingsSysteem = bestellingsSysteem // consumer: waarnaar zij moet kijken
           };           

           klant1.Bestel(ober, "Hoegaarden");
           klant2.Bestel(ober, "Koffie");
        }
    }
}
