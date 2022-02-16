using System;

namespace keuzeinput
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keuzes = { "Rood", "Groen", "Blauw" };
            int index = GetKeuze(keuzes);
            string kleur = keuzes[index];
            Console.WriteLine($"U koos {kleur}");
        }
        static int GetKeuze(string[] keuzes)
        {
            string invoer = "";
            int index = -1, i = 0 ;
            while (index ==-1)
            {
                Console.WriteLine("geeft keer een kleurke");
                invoer = Console.ReadLine().ToLower().Trim();
                foreach (string s in keuzes)
                {
                    if (invoer == s.ToLower())
                    {
                        index = i;
                    }
                    i++;
                }
                i = 0;
            }
            return index;
        }
    }
}
