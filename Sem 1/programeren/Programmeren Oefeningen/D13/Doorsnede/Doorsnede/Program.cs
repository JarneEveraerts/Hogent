using System;
using System.Collections.Generic;

namespace Doorsnede
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] temperaturenMeetpunt1 = { 10.1, 20.2, 15.5, 12.3, 28.7 };
            double[] temperaturenMeetpunt2 = { 10.0, 20.2, 15.6, 12.3, 28.8, 11.1 };

            double[] doorsnede = Doorsnede(temperaturenMeetpunt1, temperaturenMeetpunt2);
            ToonDoorsnede(doorsnede);                       // toont de tekst "20,2 | 12,3"

            double[] getallen1 = { 1.23, 2.34, 3.45 };
            double[] getallen2 = { 1.99, 2.34 };
            ToonDoorsnede(Doorsnede(getallen1, getallen2)); // toont de tekst "2,34"

            double[] getallen3 = { 1.99, 2.99, 3.99 };
            ToonDoorsnede(Doorsnede(getallen1, getallen3)); // toont de tekst "geen doorsnede"
        }

        private static double[] Doorsnede(double[] getal1, double[] getal2)
        {
            //List<double> result = new List<double>();
            double[] result = new double[(getal1.Length + getal2.Length) / 2];
            int k = 0;
            foreach (double i in getal1)
            {
                foreach (double j in getal2)
                {
                    if (i == j)
                    {
                        result[k] = i;
                        k++;
                    }
                }
            }
            return result;//.ToArray();
        }

        private static void ToonDoorsnede(double[] getal)
        {
            bool check = true;
            foreach (double d in getal)
            {
                if (d != 0)
                {
                    check = false;
                }
            }
            if (check == false)
            {
                for (int i = 0; i < getal.Length; i++)
                {
                    if (getal[i] > 0)
                    {
                        Console.Write(getal[i]);
                        if (i < getal.Length - 1)
                        {
                            if (getal[i + 1] != 0)
                            {
                                Console.Write(" | ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("geen doorsnede");
            }

            Console.WriteLine();
        }
    }
}