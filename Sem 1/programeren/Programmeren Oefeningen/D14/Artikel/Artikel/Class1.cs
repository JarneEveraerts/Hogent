using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikel
{
    internal class BTW
    {
        private double _exclusiefBtw;
        private double _btw;

        public double GetExclusief()
        {
            return _exclusiefBtw;
        }

        public void SetExclusief(double exclusief)
        {
            _exclusiefBtw = exclusief;
        }

        public double GetBtw()
        {
            return _btw;
        }

        public void SetBtw(int btw)
        {
            _btw = btw;
        }

        public double InclusiefBtw()
        {
            double inclusief = 0;
            inclusief = Math.Round(this._exclusiefBtw + ((this._btw / 100) * this._exclusiefBtw), 2);
            return inclusief;
        }
    }
}