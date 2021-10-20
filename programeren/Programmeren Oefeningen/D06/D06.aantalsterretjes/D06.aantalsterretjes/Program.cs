using System;

namespace D06.aantalsterretjes
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalSter=0;
            string aantalSterString;

            bool loop = true;


            while (loop != false)
            {
                Console.Write("Geef het aantal sterretjes: ");
                aantalSterString = Console.ReadLine();

                if (string.IsNullOrEmpty(aantalSterString))
                {
                    aantalSter = 0;
                }
                else
                {
                    aantalSter = Convert.ToInt32(aantalSterString);
                }


                if (aantalSter <= 0)
                {
                    loop = true;
                    Console.Clear();
                }
                else
                {
                    loop = false;
                }

            }

            for (int i = 0; i < aantalSter; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
