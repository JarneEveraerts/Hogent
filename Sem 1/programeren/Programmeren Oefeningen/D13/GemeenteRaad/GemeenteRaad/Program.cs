using System;

namespace GemeenteRaad
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inwonersGemeente = 259570;
            int[] lijstNummers = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            string[] lijsten = { "spa.a-Groen", "N-VA", "CD&V", "VLAAMS BELANG", "Open Vld", "PVDA", "DUW.GENT", "MRP", "SPIEGEL Partij", "BE-ONE", "GENTSE BURGERS", "VMC", "PISS-OFF" };
            int[] stemcijfers = { 53179, 19167, 13979, 12354, 39879, 11178, 3229, 498, 329, 1709, 1633, 480, 931 };

            //int inwonersGemeente = 125;
            //int[] lijstNummers = { 1, 2, 3, 4 };
            //string[] lijsten = { "Groen", "Open Vld", "N-VA", "sp.a" };
            //int[] stemcijfers = { 60, 30, 31, 4 };

            // Vraag het aantal raadsleden voor de gemeenteraad op:
            int raadsleden = Raadsleden(inwonersGemeente);

            // Vraag het aantal zetels (voor elke lijst) op:
            int[] zetels = Zetels(raadsleden, lijsten, stemcijfers);

            Print(lijstNummers, lijsten, stemcijfers, zetels);
        }

        private static void Print(int[] lijstNummers, string[] lijsten, int[] stemcijfers, int[] zetels)
        {
            for (int i = 0; i < lijstNummers.Length; i++)
            {
                Console.WriteLine($"{lijstNummers[i],2}: {lijsten[i],15:d}: {zetels[i],2:d} zetels: {stemcijfers[i],6:d} stemmen");
            }
        }

        private static int Raadsleden(int total)
        {
            int output = -1;
            int[] inwonersAantallen = { 1000, 2000, 3000, 4000, 5000, 7000, 9000, 12000, 15000,
                            20000, 25000, 30000, 35000, 40000, 50000, 60000, 70000,
                            80000, 90000, 100000, 150000, 200000, 250000, 300000 };
            int[] raadsledenAantallen = { 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35,
                              37, 39, 41, 43, 45, 47, 49, 51, 53, 55 };
            if (total < inwonersAantallen[0] && total > 0)
            {
                output = raadsledenAantallen[0];
            }
            else
            {
                for (int i = 23; i > 1; i--)
                {
                    if (total > inwonersAantallen[i])
                    {
                        output = raadsledenAantallen[i];
                        break;
                    }
                }
            }

            return output;
        }

        private static int[] Zetels(int raadsleden, string[] lijsten, int[] stemcijfers)
        {
            int[] output = new int[lijsten.Length];
            int[] stemcijfersBerekent = new int[stemcijfers.Length];
            for (int l = 0; l < stemcijfersBerekent.Length; l++)
            {
                stemcijfersBerekent[l] = stemcijfers[l];
            }
            int[] deeltal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int grootste = 0, zetelPosition = 0;
            for (int i = 0; i < raadsleden; i++)
            {
                for (int j = 0; j < stemcijfers.Length; j++)
                {
                    if (stemcijfersBerekent[j] > grootste)
                    {
                        zetelPosition = j;
                        grootste = stemcijfersBerekent[j];
                    }
                }
                grootste = 0;
                output[zetelPosition]++;
                for (int k = 0; k < output.Length; k++)
                {
                    if (output[k] > 0)
                    {
                        stemcijfersBerekent[k] = stemcijfers[k] / deeltal[output[k]];
                    }
                }
            }
            return output;
        }
    }
}