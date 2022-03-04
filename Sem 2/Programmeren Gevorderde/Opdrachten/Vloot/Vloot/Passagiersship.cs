using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vloot
{
    internal class Passagiersship : Schip
    {
        public int Passagiers { get; set; }
        public string Traject { get; set; }

        public Passagiersship(string naam, double lengte, double breedte, double tonnage, int passagiers, string traject) : base(naam, lengte, breedte, tonnage)
        {
            Passagiers = passagiers;
            Traject = traject;
        }
    }
}