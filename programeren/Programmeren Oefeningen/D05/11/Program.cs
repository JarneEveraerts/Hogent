using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een double in!");
            string Value = Console.ReadLine();
            double Number;
            bool success = double.TryParse(Value, out Number);
            while (success)
            {
                
                Console.WriteLine("danku voor de double");
                Console.WriteLine("Geef een double in!");
                Value = Console.ReadLine();
                success = double.TryParse(Value, out Number);
            }
            Console.WriteLine("einde wegens geen double");
        }
    }
}
