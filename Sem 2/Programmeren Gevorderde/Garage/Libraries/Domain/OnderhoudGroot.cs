using System;

namespace Domain
{
    public class OnderhoudGroot : Onderhoud
    {
        public OnderhoudGroot(DateTime begindatum, DateTime einddatum, string nummerplaat) :
            base(begindatum, einddatum, nummerplaat)
        {
        
        }
    }
}
