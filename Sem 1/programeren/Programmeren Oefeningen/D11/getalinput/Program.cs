using System;

namespace getalinput
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = GetGetal(1, 100);
            Console.WriteLine($"U koos voor {getal}");
        }
        static int GetGetal(int min,int max)
        {
            bool check = false;
            Console.WriteLine($"geef getal in tussen 1 en 100");
            string invoerTekst = Console.ReadLine();
            bool checkGetal = int.TryParse(invoerTekst, out int invoer);
            while (check == false)
            {
                if (checkGetal == true)
                {
                    if (invoer >max || invoer <min)
                    {
                        Console.WriteLine($"geef getal in tussen 1 en 100");
                        invoerTekst = Console.ReadLine();
                        checkGetal = int.TryParse(invoerTekst, out invoer);
                    }
                    else
                    {
                        check = true;
                    }
                }
                else
                {
                    Console.WriteLine($"geef getal in tussen 1 en 100");
                    invoerTekst = Console.ReadLine();
                    checkGetal = int.TryParse(invoerTekst, out invoer);
                }
            }
            return invoer;
        }
    }
}
