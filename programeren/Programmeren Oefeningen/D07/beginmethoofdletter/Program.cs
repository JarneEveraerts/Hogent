using System;

namespace beginmethoofdletter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef keer een woordje");
            string Invoer = Console.ReadLine();
            string Deel = Invoer.Substring(0,5);
            Invoer = Invoer.Replace(Deel, Deel.ToUpper()) ;
            Console.WriteLine(Invoer);
            

        }
    }
}
