using System;

namespace Netto
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] kortingen = { 10, 50, 19.4 };
            double brutoBedrag = 1000;
            int j = 0;
            double nettoBedrag = brutoBedrag;
            foreach (double i in kortingen)
            {
                nettoBedrag -= kortingen[j];
                j++;
            }

            Console.Write("Netto bedrag: " + nettoBedrag);
        }
    }
}
