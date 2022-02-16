using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechthoek
{
    internal class Rechthoek
    {
        private double _hoogte, _breedte;

        public double GetHoogte()
        {
            return _hoogte;
        }

        public void SetHoogte(double hoogte)
        {
            _hoogte = hoogte;
        }

        public double GetBreedte()
        {
            return _breedte;
        }

        public void SetBreedte(double breedte)
        {
            _breedte = breedte;
        }

        public double Oppervlakte()
        {
            double oppervlakte = this._breedte * this._hoogte;
            return oppervlakte;
        }
    }
}