using System;

namespace tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welke tafel wilde");
            int Invoer = Convert.ToInt16(Console.ReadLine());
            int[] Uitkomst = new int[10];
            int Totaal = 0;
            for (int i = 0; i < 10; i++)
            {
                Uitkomst[i] = (i + 1) * Invoer;
                Totaal = Totaal + Uitkomst[i];
            }
            int j = 0;
            foreach (int i in Uitkomst)
            {
                Console.Write(Uitkomst[j]+ " ");
                j++;
            }
            Console.WriteLine("");
            Console.WriteLine(Totaal);

        }
    }
}
