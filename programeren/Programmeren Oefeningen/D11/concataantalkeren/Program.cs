using System;

namespace concataantalkeren
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = ConcatAantalKeer("*-", 4);
            Console.WriteLine(output);
        }
        static string ConcatAantalKeer(string input, int aantal)
        {
            string output="";
            for (int  i = 0;  i < aantal;  i++)
            {
                output += input;
            }
            return output;
        }
    }
}
