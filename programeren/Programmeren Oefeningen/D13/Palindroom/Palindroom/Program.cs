using System;

namespace Palindroom
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Geef een tekst : ");
            string tekst = Console.ReadLine();

            Console.WriteLine(IsPalindroom(tekst));
        }

        private static bool IsPalindroom(string tekst)
        {
            string reverse = ReverseText(tekst);
            if (tekst == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string ReverseText(string tekst)
        {
            string result = "";
            for (int i = tekst.Length - 1; i > -1; i--)
            {
                result += tekst[i].ToString();
            }
            return result;
        }
    }
}