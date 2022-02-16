using System;

namespace Herkansing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] puntenlijst = { 13, 16, 13, 18, 8, 12, 15, 3, 4, 11, 17, 18 };
            int j=0;
            foreach (int i in puntenlijst)
            {
                if (i < 10)
                {
                    j++;
                }
            }
            if (j>1)
            {
                Console.WriteLine("herkansing mogenlijk");
            }
            else
            {
                Console.WriteLine("geen herkansing");
            }
        }
    }
}
