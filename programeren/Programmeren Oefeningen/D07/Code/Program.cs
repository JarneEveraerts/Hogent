using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef keer een zinneke");
            string invoer = Console.ReadLine().ToUpper();
            invoer = invoer.Replace("A", "@");
            invoer = invoer.Replace("E", "3");
            invoer = invoer.Replace("I", "1");
            invoer = invoer.Replace("U", "2");
            invoer = invoer.Replace("o", "O");
            invoer = invoer.Replace(" ", "_");
            Console.WriteLine(invoer);
        }
    }
}
