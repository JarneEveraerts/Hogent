using System;

namespace Roman_Arabic_Converter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 0, invoerLength = 0, uitvoerArabisch = 0;
            string uitvoer = "", convers = "", invoer = "";
            Console.WriteLine("kies of u arabisch of romeins invoegt");
            string keuze = Console.ReadLine().ToLower();
            bool keuzeCheck = false, doorgaan = true;
            while (keuzeCheck == false)
            {
                switch (keuze)
                {
                    case "arabisch":
                        keuzeCheck = true;
                        Console.WriteLine("geef een getal tussen 1 en 3999");
                        invoer = Console.ReadLine().ToLower();
                        bool check = int.TryParse(invoer, out int invoerCijfer), checkYN = false;
                        while (doorgaan)
                        {
                            if (check == true)
                            {
                                if (invoerCijfer < 4000 && invoerCijfer > 0)
                                {
                                    int[] cijfers = new int[invoer.Length];
                                    foreach (char c in invoer)
                                    {
                                        convers = c.ToString();
                                        cijfers[i] = Convert.ToInt16(convers);
                                        i++;
                                    }
                                    invoerLength = invoer.Length;
                                    Array.Reverse(cijfers);
                                    while (invoerLength > 0)
                                    {
                                        switch (invoerLength)
                                        {
                                            case 1: //conversion of the decimals
                                                if (cijfers[0] != 0)
                                                {
                                                    if (cijfers[0] > 8)
                                                    {
                                                        uitvoer += "IX";
                                                    }
                                                    else if (cijfers[0] > 5)
                                                    {
                                                        uitvoer += "V";
                                                        for (int j = 0; j < (cijfers[0] - 5); j++)
                                                        {
                                                            uitvoer += "I";
                                                        }
                                                    }
                                                    else if (cijfers[0] == 5)
                                                    {
                                                        uitvoer += "V";
                                                    }
                                                    else if (cijfers[0] < 4)
                                                    {
                                                        for (int j = 0; j < cijfers[0]; j++)
                                                        {
                                                            uitvoer += "I";
                                                        }
                                                        invoer = "";
                                                    }
                                                    else
                                                    {
                                                        uitvoer += "IV";
                                                    }
                                                }
                                                invoerLength--;
                                                break;

                                            case 2://conversion of the 10 numbers
                                                if (cijfers[1] != 0)
                                                {
                                                    if (cijfers[1] > 8)
                                                    {
                                                        uitvoer += "XC";
                                                    }
                                                    else if (cijfers[1] > 5)
                                                    {
                                                        uitvoer += "L";
                                                        for (int j = 0; j < (cijfers[1] - 5); j++)
                                                        {
                                                            uitvoer += "X";
                                                        }
                                                    }
                                                    else if (cijfers[0] == 5)
                                                    {
                                                        uitvoer += "L";
                                                    }
                                                    else if (cijfers[1] < 4)
                                                    {
                                                        for (int j = 0; j < cijfers[1]; j++)
                                                        {
                                                            uitvoer += "X";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        uitvoer += "XL";
                                                    }
                                                }
                                                invoerLength--;
                                                break;

                                            case 3: // conversion of the 100 number
                                                if (cijfers[2] != 0)
                                                {
                                                    if (cijfers[2] > 8)
                                                    {
                                                        uitvoer += "CM";
                                                    }
                                                    else if (cijfers[2] > 5)
                                                    {
                                                        uitvoer += "D";
                                                        for (int j = 0; j < (cijfers[2] - 5); j++)
                                                        {
                                                            uitvoer += "C";
                                                        }
                                                    }
                                                    else if (cijfers[0] == 5)
                                                    {
                                                        uitvoer += "D";
                                                    }
                                                    else if (cijfers[2] < 4)
                                                    {
                                                        for (int j = 0; j < cijfers[2]; j++)
                                                        {
                                                            uitvoer += "C";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        uitvoer += "CD";
                                                    }
                                                }
                                                invoerLength--;
                                                break;

                                            case 4://the conversion of the 1000 number
                                                if (cijfers[3] != 0)
                                                {
                                                    for (int j = 0; j < cijfers[3]; j++)
                                                    {
                                                        uitvoer += "M";
                                                    }
                                                }

                                                invoerLength--;
                                                break;
                                        }
                                    }
                                    i = 0;
                                    foreach (int c in cijfers)
                                    {
                                        cijfers[i] = -1;
                                    }
                                    //check if u want to continue the conversion
                                    checkYN = false;
                                    Console.WriteLine(uitvoer);
                                    uitvoer = "";
                                    Console.WriteLine("wens u nog een berekening te maken (Y:N");
                                    invoer = Console.ReadLine().ToLower();
                                    while (checkYN == false)
                                    {
                                        switch (invoer)
                                        {
                                            //what happens if u press Y
                                            case "y":
                                                checkYN = true;
                                                Console.WriteLine("geef een getal tussen 1 en 3999");
                                                invoer = Console.ReadLine();
                                                check = int.TryParse(invoer, out invoerCijfer);
                                                break;
                                            //what happens if u press N
                                            case "n":
                                                doorgaan = false;
                                                checkYN = true;
                                                break;
                                            //what happens if u dont do whats asked from u
                                            default:
                                                checkYN = false;
                                                Console.WriteLine("wens u nog een berekening te maken (Y:N");
                                                invoer = Console.ReadLine().ToLower();
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("geef een getal tussen 1 en 3999");
                                    invoer = Console.ReadLine();
                                    check = int.TryParse(invoer, out invoerCijfer);
                                }
                            }
                            else
                            {
                                Console.WriteLine("geef een getal tussen 1 en 3999");
                                invoer = Console.ReadLine();
                                check = int.TryParse(invoer, out invoerCijfer);
                            }
                        }
                        break;

                    case "romeins": // roman numeral conversion
                        keuzeCheck = true;
                        Console.WriteLine("geef een romeinse waarde in (I - MMMCMXCIX)");
                        invoer = Console.ReadLine().ToUpper().Trim();
                        int m = 0;
                        while (doorgaan)
                        {
                            while (invoer.Length > 0)
                            {
                                switch (invoer[0])
                                {
                                    case 'M':
                                        if (m < 3)
                                        {
                                            m++;
                                            uitvoerArabisch += 1000;
                                        invoer = invoer.Substring(1);
                                        }
                                        else
                                        {
                                            goto error;
                                        }
                                        break;

                                    case 'D':
                                        uitvoerArabisch += 500;
                                        invoer = invoer.Substring(1);
                                        break;

                                    case 'C':
                                        if (invoer.Length > 1)
                                        {
                                            switch (invoer[1])
                                            {
                                                case 'M':
                                                        uitvoerArabisch += 900;
                                                        invoer = invoer.Substring(2);
                                                    break;

                                                case 'D':
                                                    uitvoerArabisch += 400;
                                                    invoer = invoer.Substring(2);
                                                    break;

                                                default:
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            uitvoerArabisch += 100;
                                            invoer = invoer.Substring(1);
                                        }

                                        break;

                                    case 'L':
                                        uitvoerArabisch += 50;
                                        invoer = invoer.Substring(1);
                                        break;

                                    case 'X':
                                        if (invoer.Length > 1)
                                        {
                                            switch (invoer[1])
                                            {
                                                case 'C':
                                                    uitvoerArabisch += 90;
                                                    invoer = invoer.Substring(2);
                                                    break;

                                                case 'L':
                                                    uitvoerArabisch += 40;
                                                    invoer = invoer.Substring(2);
                                                    break;

                                                default:
                                                    uitvoerArabisch += 10;
                                                    invoer = invoer.Substring(1);
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            uitvoerArabisch += 10;
                                            invoer = invoer.Substring(1);
                                        }
                                        break;

                                    case 'V':
                                        uitvoerArabisch += 5;
                                        invoer = invoer.Substring(1);
                                        break;

                                    case 'I':
                                        if (invoer.Length > 1)
                                        {
                                            switch (invoer[1])
                                            {
                                                case 'X':
                                                    uitvoerArabisch += 9;
                                                    invoer = invoer.Substring(2);
                                                    break;

                                                case 'V':
                                                    uitvoerArabisch += 4;
                                                    invoer = invoer.Substring(2);
                                                    break;

                                                default:
                                                    uitvoerArabisch += 1;
                                                    invoer = invoer.Substring(1);
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            uitvoerArabisch += 1;
                                            invoer = invoer.Substring(1);
                                        }

                                        break;

                                    default:
                                    error:;
                                        m = 0;
                                        Console.WriteLine("gelieve een echt romeins cijfer in te vullen");
                                        invoer = Console.ReadLine().ToUpper();
                                        uitvoerArabisch = 0;
                                        break;
                                }
                            }
                            Console.WriteLine($"het getal in arabische cijfer: {uitvoerArabisch.ToString()}");
                            Console.WriteLine();
                            uitvoerArabisch = 0;
                            checkYN = false;
                            Console.WriteLine("wens u nog een berekening te maken (Y:N");
                            invoer = Console.ReadLine().ToUpper();
                            while (checkYN == false)
                            {
                                switch (invoer)
                                {
                                    //what happens if u press Y
                                    case "Y":
                                        checkYN = true;
                                        Console.WriteLine("geef een romeinse waarde in (tussen I en MMMCMXCIX)");
                                        invoer = Console.ReadLine().ToUpper();
                                        break;
                                    //what happens if u press N
                                    case "N":
                                        doorgaan = false;
                                        checkYN = true;
                                        break;
                                    //what happens if u dont do whats asked from u
                                    default:
                                        checkYN = false;
                                        Console.WriteLine("wens u nog een berekening te maken (Y:N");
                                        invoer = Console.ReadLine().ToUpper();
                                        break;
                                }
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("kies of u arabisch of romeins invoegt");
                        keuze = Console.ReadLine().ToLower();
                        break;
                }
            }
        }
    }
}