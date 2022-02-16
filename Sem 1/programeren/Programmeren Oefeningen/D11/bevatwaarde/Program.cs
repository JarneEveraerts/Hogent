using System;

namespace bevatwaarde
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"geef getal {i+1}#");
                getallen[i] = CheckGetal(Console.ReadLine(),getallen,i);
                
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(getallen[i]);
            }
        }
        static int CheckGetal(string invoerTekst,int[] getallen,int index)
        {
            bool check = true,toegevoegd=false;
            bool checkGetal = int.TryParse(invoerTekst, out int invoer);
            while (toegevoegd == false)
            {
                if (checkGetal == true)
                {
                    foreach (int cijfer in getallen)
                    {
                        if (cijfer == invoer)
                        {
                            check = false;
                        }
                    }
                    if (check == true)
                    {
                        toegevoegd = true;
                    }
                    else
                    {
                        Console.WriteLine($"geef getal {index + 1}#");
                        invoerTekst = Console.ReadLine();
                        checkGetal = int.TryParse(invoerTekst, out invoer);
                    }
                }
                else
                {
                    Console.WriteLine($"geef getal {index + 1}#");
                    invoerTekst = Console.ReadLine();
                    checkGetal = int.TryParse(invoerTekst, out invoer);
                }
            }
            return invoer;
            
            
        }
    }
}
