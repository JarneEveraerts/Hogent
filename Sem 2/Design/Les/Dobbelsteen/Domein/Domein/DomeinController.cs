using System;

namespace Domein
{
    public class DomeinController
    {
        private Spel _spel;

        public void StartNieuwSpel()
        {
            _spel = new Spel();
        }

        public void RollDobbelsteen()
        {
            _spel.RolDobbelstenen();
        }

        public int GeefAantalOgenWorp()
        {
            return _spel.GeefAantalOgenWorp();
        }

        public int GeefScore()
        {
            return _spel.GeefScore();
        }

        public bool IsEindeSpel()
        {
            return _spel.IsEindeSpel();
        }
    }
}