using System;

namespace VraagStringAntwoord
{
    class Program
    {
        static void Main(string[] args)
        {
            vraagStringAntwoord();
        }
        static void vraagStringAntwoord()
        {
            Console.WriteLine("wat is uw naam");
            string input = Console.ReadLine();
            bool inputCorrect=false;
            while (inputCorrect==false)
            {
                if (input.Length >0)
                {
                    inputCorrect = true;
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine("wat is uw naam");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
