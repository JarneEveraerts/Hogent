using System;

namespace reversetext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef keer een woord");
            Console.WriteLine(ReverseText(Console.ReadLine()));
        }
        static string ReverseText(string input)
        {
            string output="";

            for (int i = input.Length-1; i > -1; i--)
            {
                output += input[i].ToString();
            }
            
            return output;
        }
    }
}