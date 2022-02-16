using System;

namespace Achterstevoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoeveel namen geefde in");
            int Hoeveel = Convert.ToInt16(Console.ReadLine());
            string[] Naam = new string[Hoeveel];
            for (int i = 0; i < Hoeveel; i++)
            {
                Console.WriteLine($"geef naam {i+1}");
                Naam[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = Naam.Length; i >0 ; i--)
            {
                Console.WriteLine(Naam[i-1]);
            }
        }
    }
}
