using System;

namespace jackpot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int score = 0;
            int[] wiel = new int[3];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                wiel[i] = r.Next(11);
            }

            if (wiel[0] == 9 && wiel[1] == 9 & wiel[2] == 9)
            {
                score = 50;
            }
            else if (wiel[0] == wiel[1] && wiel[0] == wiel[2])
            {
                score = 10;
            }
            else if (wiel[0] == wiel[1] || wiel[0] == wiel[2] || wiel[1] == wiel[2])
            {
                score = 5;
            }

            Console.WriteLine($"wiel 1 = {wiel[0]} , wiel 2 = {wiel[1]} , wiel 3 = {wiel[2]} ");
            Console.WriteLine(score);
        }
    }
}