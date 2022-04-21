// HOGENT

namespace Domain
{
    // Publisher kant: stelt event beschikbaar en roept deze op
    public class Bel
    {
        #region Events
        public delegate void RingDelegate(string klant, string product); // 2de stap
        public event RingDelegate RingEvent; // 1ste stap
        #endregion

        #region Methods
        public void Ring(string klant, string product)
        {
            RingEvent?.Invoke(klant, product); // 3de stap: event oproepen
        }
        #endregion
    }
}
