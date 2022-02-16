using System;

namespace Afdrukkenarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3 };
            string Uitvoer="";
            for (int i = 0; i < a.Length; i++)
            {
                Uitvoer +=a[i].ToString();
                if (i < a.Length-1)
                {
                    Uitvoer += ", ";
                }
            }
            Console.WriteLine(Uitvoer);
            
        }
    }
}
