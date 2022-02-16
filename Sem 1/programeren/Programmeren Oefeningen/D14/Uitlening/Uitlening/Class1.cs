using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitlening
{
    internal class Uitlening
    {
        private string _omschrijving = "";
        private DateTime _ontleenDatum, _inleendatum;

        public void SetOmschrijving(string omschrijving)
        {
            _omschrijving = omschrijving;
        }

        public void SetOntleendatum(DateTime uitleendatum)
        {
            _ontleenDatum = uitleendatum;
        }

        public string GetOmschrijving()
        {
            return _omschrijving;
        }

        public DateTime GetOntleendatum()
        {
            return _ontleenDatum;
        }

        public DateTime UitersteInleverdatum()
        {
            return _ontleenDatum.AddDays(14);
        }
    }
}