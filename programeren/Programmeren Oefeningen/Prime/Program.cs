using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal, a = 0;
            string Invoer;
            Console.WriteLine("geef een getal in");
            Getal = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Getal; i++)
            {
                if (Getal % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"{Getal} is a Prime Number");
            }
            else
            {
                Console.WriteLine("het getal is geen prime number");
            }
            Console.ReadLine();
        }
    }
}
