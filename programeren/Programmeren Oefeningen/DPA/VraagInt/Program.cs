using System;

namespace VraagInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int antwoord = vraagIntAntwoord("Hoe oud bent u", 0, 99);
            Console.WriteLine($"U bent dus {antwoord} jaar oud");
        }
        static int vraagIntAntwoord(string vraag,int min,int max)
        {
            Console.WriteLine(vraag);
            bool isInt = int.TryParse(Console.ReadLine(), out int antwoord);
            int i = 0;
            while (i==0)
            {
                if (isInt)
                {
                    if (antwoord > max)
                    {
                        Console.WriteLine(vraag);
                        isInt = int.TryParse(Console.ReadLine(), out antwoord);
                    }
                    else if (antwoord < min)
                    {
                        Console.WriteLine(vraag);
                        isInt = int.TryParse(Console.ReadLine(), out antwoord);
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine(vraag);
                    isInt = int.TryParse(Console.ReadLine(), out antwoord);
                }
            }
            return antwoord;



        }
    }
}
