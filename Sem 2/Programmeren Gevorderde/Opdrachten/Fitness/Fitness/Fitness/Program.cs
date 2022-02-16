using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Fitness
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> sessions = new List<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            using (var reader = new StreamReader(@"C:\Users\evera\OneDrive\Documents\Hogent\Sem 2\Programmeren Gevorderde\Opdrachten\Fitness\fitness_data.sql"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = line.Replace("insert into runningsession values(", "");
                    line = line.Replace(")", "");
                    var values = line.Split(';');
                    foreach (var value in values)
                    {
                        sessions.Add(value);
                    }
                }
                string invoer = "";
                invoer = Input();

                while (invoer != "3")
                {
                    switch (invoer)
                    {
                        case "1": KlantNr(); break;
                        case "2": Date(sessions); break;
                    }
                    invoer = Input();
                }
            }
        }

        private static void KlantNr()
        {
        }

        private static void Date(List<string> values)
        {
            List<Session> session = new List<Session>();
            string date = checkDate();
            IEnumerable<string> query = values.Where(value => value.Contains(date));
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
            foreach (Session sesh in session)
            {
                Console.WriteLine($"Sessie: {sesh.SessieNr}, Date: {sesh.Date}, Klant: {sesh.KlantId}, Snelheid: {sesh.AVGSpeed} Duur: {sesh.TotTime}, Intervals: {sesh.Seqnr.Count}");
                for (int j = 0; j < sesh.Seqnr.Count; j++)
                {
                    Console.WriteLine($"   SeqNr: {sesh.Seqnr[j]}, Snelheid: {sesh.SeqSpeed[j]} , Duur:");
                }
            }
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

        private bool Check(string[] split)
        {
            bool check = false;
            if (int.Parse(split[0]) > 0)
            {
                if (int.Parse(split[2]) > 0)
                {
                    if (int.Parse(split[3]) > 5 && int.Parse(split[3]) < 180)
                    {
                        if (int.Parse(split[4]) > 5 && int.Parse(split[4]) < 22)
                        {
                            if (int.Parse(split[5]) > 0)
                            {
                                if (int.Parse(split[6]) > 5 && int.Parse(split[6]) < 10800)
                                {
                                    if (int.Parse(split[7]) > 5 && int.Parse(split[7]) < 22)
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

        private static string Input()
        {
            Menu();
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

        private static void Menu()
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