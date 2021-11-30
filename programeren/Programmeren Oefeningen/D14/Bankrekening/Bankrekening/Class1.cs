using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    internal class Bankrekening
    {
        private decimal _saldo;
        private Bankrekening a, _b;

        public void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
        }

        public void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
        }

        public decimal Saldo()
        {
            return _saldo;
        }

        public void Overschrijven(Bankrekening b, decimal bedrag)
        {
            _saldo = _saldo - bedrag;
            b.Stort(bedrag);
        }
    }
}