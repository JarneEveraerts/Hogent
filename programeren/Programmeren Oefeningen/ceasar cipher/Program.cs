using System;

namespace ceasar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cipher = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", Uncoded, Coded="";
            Console.WriteLine("geef u uncoded bericht in");
            Uncoded = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("geef u turns in");
            int Turns = Convert.ToInt16(Console.ReadLine());
            foreach (char c in Uncoded)
            {
                if ( c ==' ')
                {
                    Coded += " ";
                }
                else
                {
                    Coded += Cipher.Substring(Cipher.IndexOf(c) + Turns, 1);
                }
                
            }
            Console.WriteLine(Coded);


        }
    }
}
