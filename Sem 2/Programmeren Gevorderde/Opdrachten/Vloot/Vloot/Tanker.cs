using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vloot
{
    internal class Tanker : Vrachtschip
    {
        public double Volume { get; set; }

        public Tanker(string naam, double lengte, double breedte, double tonnage, double cargowaarde, double volume) : base(naam, lengte, breedte, tonnage, cargowaarde)
        {
            Volume = volume;
        }

        public Tanker()
        {
        }
    }
}