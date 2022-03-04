using System;

namespace Domein
{
    public class Dobbelsteen
    {
        public int AantalOgen { get; set; }

        public Dobbelsteen()
        {
        }

        public void Rol()
        {
            Random r = new Random();
            AantalOgen = r.Next(1, 7);
        }
    }
}