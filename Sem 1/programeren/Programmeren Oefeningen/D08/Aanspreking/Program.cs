using System;

namespace Aanspreking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aansprekingen = { "Jan", "Piet", "Pol" };
            int i = 0;
            foreach (string lol in aansprekingen)
            {
                aansprekingen[i] = "dag " + aansprekingen[i] ;
                i++;
            }

            foreach (string aanspreking in aansprekingen)
            {
                Console.WriteLine(aanspreking);
            }
        }
    }
}
