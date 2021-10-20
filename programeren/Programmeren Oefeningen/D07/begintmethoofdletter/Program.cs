using System;

namespace begintmethoofdletter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef ke e woordje");
            string Invoer = Console.ReadLine();
            if (char.IsUpper(Invoer[0]))
            {
                Console.WriteLine("woord start me hoofdletter");
            }
            else
            {
                Console.WriteLine("woord start me kleine letter");
            }
        }
    }
}
