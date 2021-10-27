using System;

namespace Zoekeninarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4};
            Console.WriteLine("geef keer een cijfer");
            int j = 0;
            int Invoer = Convert.ToInt32(Console.ReadLine());
            string Uitvoer="";
            foreach (int i in a)
            {
                if (a[j]==Invoer)
                {
                    Uitvoer += (j + 1) + " ";
                }
                j++;
            }
            if (Uitvoer!="")
            {
                Console.WriteLine($"het getal {Invoer} staat op positie(s): {Uitvoer}");
            }
            else
            {
                Console.WriteLine("het getal werd niet gevonden");
            }
        }
    }
}
