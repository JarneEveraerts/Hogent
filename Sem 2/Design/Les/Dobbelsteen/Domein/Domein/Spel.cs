using System;
using System.Collections.Generic;

namespace Domein
{
    public class Spel
    {
        public int Score { get; set; }
        public int EersteWorp { get; set; }
        private List<Dobbelsteen> _dobbelStenen;

        public Spel()
        {
            Score = -1;
            EersteWorp = 0;

            _dobbelStenen.Add(new Dobbelsteen());
            _dobbelStenen.Add(new Dobbelsteen());
        }

        public void RolDobbelstenen()
        {
            int huidigeworp = 0;
            foreach (Dobbelsteen d in _dobbelStenen)
            {
                d.Rol();
                huidigeworp += d.AantalOgen;
            }
            BepaalScore(huidigeworp);
            BepaalEersteWorp(huidigeworp);
        }

        private void BepaalEersteWorp(int huidigeWorp)
        {
            if (EersteWorp == 0)
            {
                EersteWorp = huidigeWorp;
            }
        }

        private void BepaalScore(int huidigeWorp)
        {
            if (EersteWorp == 0)
            {
                if (huidigeWorp == 7 || huidigeWorp == 11)
                {
                    Score = 2;
                }
            }
            else
            {
                if (huidigeWorp == 7 || huidigeWorp == 11)
                {
                    Score = 2;
                }
                else
                {
                    if (huidigeWorp == EersteWorp)
                    {
                        Score = 1;
                    }
                }
            }
        }

        public int GeefAantalOgenWorp()
        {
            int huidigeWorp = 0;
            foreach (Dobbelsteen d in _dobbelStenen)
            {
                huidigeWorp += d.AantalOgen;
            }

            return huidigeWorp;
        }

        public int GeefScore()
        {
            return Score;
        }

        public bool IsEindeSpel()
        {
            if (Score == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}