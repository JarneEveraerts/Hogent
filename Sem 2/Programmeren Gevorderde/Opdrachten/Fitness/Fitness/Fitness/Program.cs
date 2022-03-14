using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Fitness
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            File.Delete("error.txt");
            List<string> sessions = new List<string>();
            List<string> error = new List<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            using (var reader = new StreamReader("fitness_data.sql"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = line.Replace("insert into runningsession values(", "");
                    line = line.Replace(");", "");
                    if (check(line))
                    {
                        sessions.Add(line);
                    }
                    else
                    {
                        error.Add(line);
                    }
                }
                ignore(error.ToArray());
                string invoer = "";
                invoer = Input();

                while (invoer != "3")
                {
                    switch (invoer)
                    {
                        case "1": Console.Clear(); KlantNr(sessions); break;
                        case "2": Console.Clear(); Date(sessions); break;
                    }
                    invoer = Input();
                }
            }
        }

        private static void KlantNr(List<string> values)
        {
            string nr = checkKlant();
            checkData(values, nr);
        }

        private static void Date(List<string> values)
        {
            string date = checkDate();
            checkData(values, date);
        }

        private static void checkData(List<string> values, string data)
        {
            List<Session> session = new List<Session>();
            IEnumerable<string> query = values.Where(value => value.Contains(data));
            int currentSesh = 0;
            int i = -1;
            foreach (string value in query)
            {
                int sesh = int.Parse(value.Substring(0, value.IndexOf(",")));
                if (sesh == currentSesh)
                {
                    session[i].AddSeq(value);
                }
                else
                {
                    i++;
                    currentSesh = sesh;
                    session.Add(new Session(value));
                }
            }
            displayData(session);
        }

        private static void displayData(List<Session> session)
        {
            if (session.Count != 0)
            {
                foreach (Session sesh in session)
                {
                    Console.WriteLine($"Sessie: {sesh.SessieNr}, Date: {sesh.Date}, Klant: {sesh.KlantId}, Snelheid: {sesh.AVGSpeed} Duur: {sesh.TotTime}, Intervals: {sesh.Seqnr.Count}");
                    for (int j = 0; j < sesh.Seqnr.Count; j++)
                    {
                        Console.WriteLine($"   SeqNr: {sesh.Seqnr[j]}, Snelheid: {sesh.SeqSpeed[j]} , Duur: {sesh.SeqTime[j]}");
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geen sessie gevonden");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        private static string checkKlant()
        {
            bool check = false;
            string input = "";
            while (!check)
            {
                Console.WriteLine("Geef een klantnr in");
                input = Console.ReadLine().Trim();
                check = int.TryParse(input, out int output);
                if (!check)
                {
                    ErrorInput();
                }
            }
            input = "'," + input + ",";
            return input;
        }

        private static string checkDate()
        {
            bool check = false;
            string input = "";
            while (!check)
            {
                Console.WriteLine("Geef een datum in (yyyy-mm-dd)");
                input = Console.ReadLine().Trim();
                if (input.Length == 10)
                {
                    if (input[4] == '-' && input[7] == '-')
                    {
                        check = DateTime.TryParse(input, out DateTime output);
                    }
                    else
                    {
                        ErrorInput();
                    }
                }
                else
                {
                    ErrorInput();
                }
            }
            return input;
        }

        private static bool check(string line)
        {
            string[] split = line.Split(",");
            split[4] = split[4].Replace(".", ",");
            split[7] = split[7].Replace(".", ",");
            bool check = false;
            if (int.Parse(split[0]) > 0)
            {
                if (int.Parse(split[2]) > 0)
                {
                    if (int.Parse(split[3]) > 5 & int.Parse(split[3]) < 181)
                    {
                        if (double.Parse(split[4]) > 5 & double.Parse(split[4]) < 22)
                        {
                            if (int.Parse(split[5]) > 0)
                            {
                                if (int.Parse(split[6]) > 5 & int.Parse(split[6]) < 10800)
                                {
                                    if (double.Parse(split[7]) > 5 & double.Parse(split[7]) < 22)
                                    {
                                        check = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return check;
        }

        private static void ignore(string[] line)
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText("error.txt"))
            {
                sw.WriteLine("All lines that got ignored");
                sw.WriteLine();
                sw.WriteLine();
                foreach (string error in line)
                {
                    sw.WriteLine(error);
                }
            }
        }

        private static string Input()
        {
            PrintMenu();
            bool checkInt = false;
            string input = "";
            bool check = false;
            while (!check)
            {
                input = Console.ReadLine();
                if (input.Length > 1 || input.Length > 1)
                {
                    ErrorInput();
                }
                else
                {
                    checkInt = int.TryParse(input, out int inputInt);
                    if (checkInt)
                    {
                        switch (inputInt)
                        {
                            case 1: check = true; break;
                            case 2: check = true; break;
                            case 3: check = true; break;
                            default: ErrorInput(); break;
                        }
                    }
                    else
                    {
                        ErrorInput();
                    }
                }
            }

            return input;
        }

        private static void ErrorInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("U heeft een foute invoer");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("* hoe wilt u de sessies opzoeken (NR): *");
            Console.WriteLine("* 1: Klant Nummer                      *");
            Console.WriteLine("* 2: Datum                             *");
            Console.WriteLine("* 3: Exit                              *");
            Console.WriteLine("****************************************");
        }
    }
}