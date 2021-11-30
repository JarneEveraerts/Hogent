using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkel
{
    internal class Cirkel
    {
        private double _straal;

        public void SetStraal(double straal)
        {
            _straal = straal;
        }

        public double GetStraal()
        {
            return _straal;
        }

        public double Oppervlakte()
        {
            double oppervlakte = Math.Round(this._straal * this._straal * Math.PI, 2);
            return oppervlakte;
        }
    }
}