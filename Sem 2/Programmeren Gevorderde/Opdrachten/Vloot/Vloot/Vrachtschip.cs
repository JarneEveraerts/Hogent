using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vloot
{
    internal class Vrachtschip : Schip
    {
        public double Cargowaarde { get; set; }

        public Vrachtschip(string naam, double lengte, double breedte, double tonnage, double cargowaarde) : base(naam, lengte, breedte, tonnage)
        {
            Cargowaarde = cargowaarde;
        }

        public Vrachtschip()
        {
        }
    }
}