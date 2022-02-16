using System;

namespace Romeins___Arabisch_efficient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] romeinsEenheid = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] romeinsTiental = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] romeinsHonderdtal = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] romeinsDuizendtal = { "", "M", "MM", "MMM" };
            bool keuzeCheck = false;
            Console.WriteLine("maak een keuze Arabische-Romeinse invoer");
            string keuze = Console.ReadLine().Trim().ToLower();
            while (keuzeCheck == false)
            {
                switch (keuze)
                {
                    case "arabisch":
                        keuzeCheck = true;
                        int[] cijfer = new int[4];
                        int invoerCijfer;
                        Console.WriteLine("geef een getal tussen 1 - 3999");
                        string invoer = Console.ReadLine().Trim().ToUpper();
                        bool cijferCheck = int.TryParse(invoer, out invoerCijfer);
                        while (invoer != "N")
                        {
                            if (cijferCheck)
                            {
                                for (int i = 0; i < invoer.Length; i++)
                                {
                                    cijfer[i] = Convert.ToInt32(invoer[i].ToString());
                                }
                                Array.Reverse(cijfer);
                                switch (invoer.Length)
                                {
                                    case 1:
                                        Console.WriteLine(romeinsEenheid[cijfer[3]]);
                                        break;

                                    case 2:
                                        Console.Write(romeinsTiental[cijfer[3]]);
                                        Console.WriteLine(romeinsEenheid[cijfer[2]]);
                                        break;

                                    case 3:
                                        Console.Write(romeinsHonderdtal[cijfer[3]]);
                                        Console.Write(romeinsTiental[cijfer[2]]);
                                        Console.WriteLine(romeinsEenheid[cijfer[1]]);
                                        break;

                                    case 4:
                                        Console.Write(romeinsDuizendtal[cijfer[3]]);
                                        Console.Write(romeinsHonderdtal[cijfer[2]]);
                                        Console.Write(romeinsTiental[cijfer[1]]);
                                        Console.WriteLine(romeinsEenheid[cijfer[0]]);
                                        break;
                                }
                                Console.WriteLine("geef een getal tussen 1 - 3999(N om te stoppen)");
                                invoer = Console.ReadLine().Trim().ToUpper();
                                cijferCheck = int.TryParse(invoer, out invoerCijfer);
                            }
                            else
                            {
                                Console.WriteLine("geef een getal tussen 1 - 3999(N om te stoppen)");
                                invoer = Console.ReadLine().Trim().ToUpper();
                                cijferCheck = int.TryParse(invoer, out invoerCijfer);
                            }
                        }
                        break;

                    case "romeins":
                        keuzeCheck = true;
                        Console.WriteLine("geef een getal tussen I en MMMCMXCIX(N om te stoppen)");
                        invoer = Console.ReadLine().ToUpper();
                        while (invoer != "N")
                        {
                            string[] uitvoerArray = new string[4];
                            for (int i = 0; i < romeinsDuizendtal.Length; i++)
                            {
                                if (invoer.Contains(romeinsDuizendtal[i]))
                                {
                                    uitvoerArray[0] = i.ToString();
                                }
                            }
                            for (int i = 0; i < romeinsHonderdtal.Length; i++)
                            {
                                if (invoer.Contains(romeinsHonderdtal[i]))
                                {
                                    uitvoerArray[1] = i.ToString();
                                }
                            }
                            for (int i = 0; i < romeinsTiental.Length; i++)
                            {
                                if (invoer.Contains(romeinsTiental[i]))
                                {
                                    uitvoerArray[2] = i.ToString();
                                }
                            }
                            for (int i = 0; i < romeinsEenheid.Length; i++)
                            {
                                if (invoer.Contains(romeinsEenheid[i]))
                                {
                                    uitvoerArray[3] = i.ToString();
                                }
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write(uitvoerArray[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine("geef een getal tussen I en MMMCMXCIX(N om te stoppen)");
                            invoer = Console.ReadLine().ToUpper();
                        }
                        break;

                    default:
                        Console.WriteLine("maak een keuze Arabische-Romeinse invoer");
                        keuze = Console.ReadLine().Trim().ToLower();
                        break;
                }
            }
        }
    }
}