using System;

namespace Dagnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dag;
            string Maand;
            Console.WriteLine("geef de nummer van de dagen in (365)");
            Dag = int.Parse(Console.ReadLine());
            if (Dag > 334)
            {
                Maand = "December";
            }
            else if (Dag>304)
            {
                Maand = "November";
            }
            else if (Dag>273)
            {
                Maand = "Oktober";
            }
            else if (Dag >243)
            {
                Maand = "September";
            }
            else if (Dag >212)
            {
                Maand = "Augustus";
            }
            else if (Dag >181)
            {
                Maand = "Juli";
            }
            else if (Dag >151)
            {
                Maand = "Juni";
            }
            else if (Dag > 120)
            {
                Maand = "Mei";
            }
            else if (Dag > 90)
            {
                Maand = "April";
            }
            else if (Dag > 59)
            {
                Maand = "Maart";
            }
            else if (Dag > 31)
            {
                Maand = "Februari";
            }
            else
            {
                Maand = "Januari";
            }
            Console.WriteLine($"het is {Maand}");
        }
    }
}
