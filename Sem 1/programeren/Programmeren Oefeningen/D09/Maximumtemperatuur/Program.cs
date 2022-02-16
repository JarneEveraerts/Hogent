using System;

namespace Maximumtemperatuur
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] meetwaarden = { 13.4, 12.1, 10.8, 10.8, 10.3, 8.9, 7.9, 7.8, 7.4, 7.2, 6.4, 9.7, 13.7, 17.2, 19.6, -9999.0, -9999.0, 22.4, 22.7, 22.8, 22.3, 18.4 };
            double Max = 0;
            int i = 0;
            string invoer;
            double Invoer;
            bool Check = false;
            double[] meetwaarden = new double[23];
            while (i<22)
            {
                Console.WriteLine("geef keer een temperatuur (1 per u/ max 24 data");
                invoer = Console.ReadLine();
                Check = double.TryParse(invoer, out Invoer);
                switch (Check)
                {
                    case false: meetwaarden[i] = -9999.99;
                        break;
                    default: meetwaarden[i] = Invoer;
                        break;
                }
                i++;
            }
            foreach(double d in meetwaarden)
            {
                if(d > Max)
                {
                    Max = d;
                }
            }
            Console.WriteLine($"u max temperatuur is {Max}°C");
        }
    }
}
