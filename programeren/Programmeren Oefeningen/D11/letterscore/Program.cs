using System;

namespace letterscore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Geef de score in % : ");
            string scoreAlsTekst = Console.ReadLine();
            int score = int.Parse(scoreAlsTekst);
            string letter = GetLetterCodeForPercentage(score);
            Console.WriteLine($"In Amerika is dat een \"{letter}\"");
        }

        private static string GetLetterCodeForPercentage(int score)
        {
            string letter = "";
            if (score < 85)
            {
                letter = "A";
            }
            else if (score < 75)
            {
                letter = "A-";
            }
            else if (score < 70)
            {
                letter = "B";
            }
            else if (score < 65)
            {
                letter = "C";
            }
            else if (score<60)
            {
                letter = "D";
            }
            else if (score<55)
            {
                letter = "F";
            }
            else
            {
                letter = "A+";
            }
            return letter;
        }
    }
}