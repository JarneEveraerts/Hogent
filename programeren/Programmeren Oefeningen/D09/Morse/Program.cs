using System;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            int i = 0;
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("geef morse in");
            string Invoer = Console.ReadLine().Trim().ToLower();
            string Uitvoer = "";
            bool IsMorse = false;
            while (Invoer != "stop")
            {
                foreach(string s in morse)
                {
                    if(s == Invoer)
                    {
                        Uitvoer += letters[i];
                        IsMorse = true;
                        Console.WriteLine($"Opgebouwt woord is: {Uitvoer}");
                    }
                    i++;
                }
                i = 0;
                
                if (IsMorse==false)
                {
                    Console.WriteLine("ongeldige morse");
                    Console.WriteLine();
                }
                Console.WriteLine("geef morse in");
                Invoer = Console.ReadLine().Trim().ToLower();
            }
        }
    }
}
