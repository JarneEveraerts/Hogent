using System;

namespace dierenwissenarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            do
            {
                ToonDieren(boerderijDieren);
                boerderijDieren = WisDierVanGebruiker(boerderijDieren);
            } while (true);
        }
        static void ToonDieren(string[] boerderijDieren)
        {
            foreach (string s in boerderijDieren)
            {
                if (s == null)
                {
                    Console.Write("GEWIST ");
                }
                else
                {
                    Console.Write(s + " ");
                }
            }
        }
        static string[] WisDierVanGebruiker(string[] boerderijDieren)
        {
            Console.WriteLine("welk dier wilt u wissen");
            string invoer = Console.ReadLine().ToLower().Trim();
            int i = 0;
            foreach (string s in boerderijDieren)
            {
                if (s == invoer)
                {
                    boerderijDieren[i] = null;
                }
                i++;
            }
            return boerderijDieren;
        }
    }
}
