using System;

namespace palindroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef keer ne palindroom");
            Console.WriteLine(GetPalindroom(Console.ReadLine()));
        }
        static string GetPalindroom(string invoer)
        {
            char[] invoerChar = invoer.ToCharArray();
            Array.Reverse(invoerChar);
            string output = "",check="geen palindroom";
            foreach (char c in invoerChar)
            {
                output += c.ToString();
            }
            if (output == invoer)
            {
                check = "palindroom";
            }
            return check;
        }
    }
}
