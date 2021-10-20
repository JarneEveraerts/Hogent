using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengteInCm, gewichtInKg;
            double BMI;
            Console.WriteLine("geef gewicht in kg");
            gewichtInKg = double.Parse(Console.ReadLine());
            Console.WriteLine("geef lengte in centimeter");
            lengteInCm = double.Parse(Console.ReadLine());

            double LengteInMeter = lengteInCm / 100;
            BMI = gewichtInKg/(LengteInMeter * LengteInMeter);
            if (BMI >= 40)
            {
                Console.WriteLine($"{BMI} (Ernstig Zwaarlijvig)");
            }
            else if (BMI >= 30)
            {
                Console.WriteLine($"{BMI} (Zwaarlijvig)");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine($"{BMI} (Overgewicht)");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine($"{BMI} (Normaal gewicht)");
            }
            else
            {
                Console.WriteLine($"{BMI} (Ondergewicht)");
            }
            
        }
    }
}
