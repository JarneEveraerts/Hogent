using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vloot
{
    internal class Schip
    {
        public string Naam { get; set; }
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Tonnage { get; set; }

        public Schip(string naam, double lengte, double breedte, double tonnage)
        {
            Naam = naam;
            Lengte = lengte;
            Breedte = breedte;
            Tonnage = tonnage;
        }

        public Schip()
        {
        }
    }
}