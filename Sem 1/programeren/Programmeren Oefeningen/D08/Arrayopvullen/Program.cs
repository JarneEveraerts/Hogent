using System;

namespace Arrayopvullen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];
            int getal = 101, i = 0;
            // opvullen
            foreach  (int j in getallen)
            {
                getallen[i] = getal;
                getal++;
                i++;
            }

            // afdrukken
            for (int index = 0; index < getallen.Length; index++)
            {
                Console.Write(getallen[index] + " ");
            }
        }
    }
}
