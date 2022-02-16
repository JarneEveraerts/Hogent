using System;

namespace Langste
{
    class Program
    {
        static void Main(string[] args)
        {
            string Invoer, Check, Langste="";
            Console.WriteLine("geef keer een zinneke");
            Invoer = Console.ReadLine().ToLower().TrimStart()+" ";
            while (Invoer.Contains(" "))
            {
                Check = Invoer.Substring(0, Invoer.IndexOf(" "));
                if (Check.Length>Langste.Length)
                {
                    Langste = Check;
                }
                Invoer = Invoer.Remove(0, Invoer.IndexOf(" ")+1);
            }
            Console.WriteLine($"het langste woord is {Langste}");
        }
    }
}
;