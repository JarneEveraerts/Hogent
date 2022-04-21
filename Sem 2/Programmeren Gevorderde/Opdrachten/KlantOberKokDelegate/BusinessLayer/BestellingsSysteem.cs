// HOGENT

namespace Domain
{
    public class BestellingsSysteem
    {
        #region Events
        public delegate void BestellingDelegate(string klant, string product);
        public event BestellingDelegate BestellingEvent;
        #endregion

        #region Methods
        public void GeefBestellingIn(string klant, string product)
        {
            // Oproepen van event - als publisher (ik notify de consumers):
            BestellingEvent?.Invoke(klant, product);
        }
        #endregion
    }
}
