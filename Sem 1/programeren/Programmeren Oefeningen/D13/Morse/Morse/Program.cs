using System;
using System.Collections.Generic;
using System.IO;

namespace Morse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string tekst = "";
            ConsoleKeyInfo input = Console.ReadKey();
            string morse = "";
            do
            {
                if (input.Key >= ConsoleKey.A && input.Key <= ConsoleKey.Z)
                {
                    tekst += input.KeyChar;
                    morse += SchrijfMorse(input.KeyChar);
                }
                if (input.Key == ConsoleKey.Spacebar)
                {
                    morse += " ";
                }

                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);
            //programma wil eerste letter niet schrijven ookal staat het in strin tekst wel juist
            Console.Clear();
            Console.WriteLine(tekst);
            Console.WriteLine(morse);
            SpeelMorse(morse);
        }

        private static string SchrijfMorse(char character)
        {
            int i = 0;
            string output = "";
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char c in letters)
            {
                if (c == character)
                {
                    output = morse[i];
                }
                i++;
            }
            return output;
        }

        private static void SpeelMorse(string input)
        {
            const int frequentie = 500;
            foreach (char c in input)
            {
                switch (c)
                {
                    case '.':
                        Console.Beep(frequentie, 500);
                        System.Threading.Thread.Sleep(150);
                        break;

                    case '-':
                        Console.Beep(frequentie, 1000);
                        System.Threading.Thread.Sleep(150);
                        break;

                    default:
                        System.Threading.Thread.Sleep(300);
                        break;
                }
            }
        }
    }
}