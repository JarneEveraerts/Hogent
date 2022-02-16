using System;

namespace tussenaccolades
{
    class Program
    {
        static void Main(string[] args)
        {
            int Begin, Lengte, Einde;
            string Invoer,Gevonden="";
            Console.WriteLine("geef keer een zinneke");
            Invoer = Console.ReadLine();
            
            
            
            
            if (Invoer.Contains('{'))
            {
                Begin = Invoer.IndexOf('{');
                if (Invoer.Contains('}'))
                {
                    Einde = Invoer.IndexOf('}');
                    Lengte = Einde - Begin;
                    Gevonden = Invoer.Substring(Begin + 1, Lengte - 1);
                    if (Gevonden != "")
                    {
                        Console.WriteLine($"het woord is {Gevonden}");
                    }
                }
                
            }
            
        }
    }
}
