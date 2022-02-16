using System;

namespace Dagnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef keer een cijfer");
            string invoer = Console.ReadLine().Trim();
            string[] Week = new string[7] { "ma", "di", "wo", "do", "vr", "za", "zo" };
            int Dag;
            bool Check = int.TryParse(invoer, out Dag);
            if (Check)
            {
                switch (Dag)
                {
                    case 1: Console.WriteLine($"het is {Week[0]}"); break; 
                    case 2: Console.WriteLine($"het is {Week[1]}"); break;
                    case 3: Console.WriteLine($"het is {Week[2]}"); break;
                    case 4: Console.WriteLine($"het is {Week[3]}"); break;
                    case 5: Console.WriteLine($"het is {Week[4]}"); break;
                    case 6: Console.WriteLine($"het is {Week[5]}"); break;
                    case 7: Console.WriteLine($"het is {Week[6]}"); break;
                }
            }
            else
            {
                Console.WriteLine("ni mee rammelen e");
            }
        }
    }
}
