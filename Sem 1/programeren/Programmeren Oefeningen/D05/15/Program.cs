using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operator="";
            string getalAlsTekst = Console.ReadLine();
            int Getal,Uitkomst=0;
            bool invoerOk = int.TryParse(getalAlsTekst, out Getal);
            Uitkomst = Getal;
           
            while (!invoerOk)
            {
                Console.WriteLine("Gelieve een geheel getal in te voeren.");
                getalAlsTekst = Console.ReadLine();
                invoerOk = int.TryParse(getalAlsTekst, out Getal);
            }
            do
            {
                Console.WriteLine("geef operator in (+ of -) (= stopt het programma)");
                Operator = Console.ReadLine();
                if (Operator == "-")
                {
                    Uitkomst = Uitkomst - Getal;
                    invoerOk = false;
                    while (!invoerOk)
                    {
                        Console.WriteLine("Gelieve een geheel getal in te voeren.");
                        getalAlsTekst = Console.ReadLine();
                        invoerOk = int.TryParse(getalAlsTekst, out Getal);
                    }
                }
                else if (Operator == "+")
                {
                    Uitkomst = Uitkomst + Getal;
                    invoerOk = false;
                    while (!invoerOk)
                    {
                        Console.WriteLine("Gelieve een geheel getal in te voeren.");
                        getalAlsTekst = Console.ReadLine();
                        invoerOk = int.TryParse(getalAlsTekst, out Getal);
                    }
                }
            } while ((Getal != 0) && (Operator != "="));
            Console.Write($"=\n{Uitkomst}");
        }
    }
}
