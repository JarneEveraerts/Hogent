using System;

namespace isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef ke een isogrammeke");
            string Invoer = Console.ReadLine();
            char[] Check = new char[Invoer.Length];
            int i = 0,k=0;
            bool IsIsogram = true;
            foreach (char C in Invoer)
            {
                Check[i] = C;
                i++;
            }
            for (i = 0; i < Invoer.Length; i++)
            {
                for (int j = 0; j < Invoer.Length-1; j++)
                {
                    if (Check[i] == Check[j])
                    {
                        k++;
                    }
                    
                    
                }
                if (k > 1)
                {
                    IsIsogram = false;
                    k = 0;
                }
                else
                {
                    k = 0;
                }
            }
            if (IsIsogram)
            {
                Console.WriteLine("is isogram");
            }
            else
            {
                Console.WriteLine("is geen isogram");
            }
            
        }
    }
}
