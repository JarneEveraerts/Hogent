using System;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { -4, 7, 9, 34, 2, 56, 34, 78 };
            Console.WriteLine(BepaalMinimum(getallen));
            Console.WriteLine(BepaalMaximum(getallen));
        }
        static string BepaalMinimum(int[] getallen)
        {
            int uitvoer=999999999;
            foreach (int i in getallen)
            {
                if (i<uitvoer)
                {
                    uitvoer = i;
                }
            }
            return uitvoer.ToString();
        }
        static string BepaalMaximum(int[] getallen)
        {
            int uitvoer = -999999999;
            foreach (int i in getallen)
            {
                if (i > uitvoer)
                {
                    uitvoer = i;
                }
            }
            return uitvoer.ToString();
        }
    }
}
