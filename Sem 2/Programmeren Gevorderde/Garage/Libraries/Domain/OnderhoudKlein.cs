using System;

namespace Domain
{
    public class OnderhoudKlein : Onderhoud
    {
        public OnderhoudKlein(DateTime begindatum, string nummerplaat) : base(begindatum, begindatum, nummerplaat)
        {

        }
    }
}
