using System;

namespace Buisvakken
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            int j = 0;
            foreach (int i in scores)
            {
                if (i <55)
                {
                    Console.WriteLine($"u heb een onvoldoende op: {vakken[j]}");
                }
                j++;
            }
        }
    }
}
