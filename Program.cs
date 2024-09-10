// See https://aka.ms/new-console-template for more information
using System.Collections;
using Uebung_Lottozahlen;
internal class Program
{
    private static void Main(string[] args)
    {
        bool validNumber = true, exit = false;

        do
        {
            bool validInput = false;
            int userInput;

            Console.Clear();
            Title.PrintTitle();
            Console.WriteLine("\tWähle aus:\n");
            Console.WriteLine("\t\t1 '6 aus 49' spielen");
            Console.WriteLine("\t\t2 Statistik anzeigen");
            Console.WriteLine("\t\t3 Beenden");

            do
            {
                Console.Write("\n\tDeine Entscheidung: ");

                validInput = int.TryParse(Console.ReadLine(), out userInput);
                switch (userInput)
                {
                    case 1:
                        PlayLotto();
                        validInput = true;
                        break;
                    case 2:
                        ShowStatistic();
                        validInput = true;
                        break;
                    case 3:
                        return;
                    default:
                        validInput = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\t\tUngültige Option.");
                        Console.ResetColor();
                        break;
                }
            } while (!validInput);

        } while (!exit);

        static void ShowStatistic()
        {
            Console.Clear();
            Title.PrintTitle();
            Console.WriteLine("\n\tIn Bearbeitung ...");
            Console.WriteLine("\n\tBitte Enter drücken um fortzusetzen.");
            Console.ReadLine();
        }

        void PlayLotto()
        {
            int[] lottoNumbers = new int[6], userNumbers = new int[6];
            ArrayList hitNumbers = new ArrayList();

            Console.Clear();
            Title.PrintTitle();

            Console.WriteLine("\tGib bitte 6 Zahlen von 1 bis 49 ein!\n");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                do
                {
                    Console.Write($"\tDeine Zahl {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out userNumbers[i]) && userNumbers[i] > 0 && userNumbers[i] <= 49)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (userNumbers[j] == userNumbers[i])
                            {
                                validNumber = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t\tDeine Zahl ist doppelt!");
                                Console.ResetColor();
                                i--;
                                break;
                            }
                        }

                        validNumber = true;
                    }
                    else
                    {
                        validNumber = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\tBitte gib eine gueltige Zahl ein!");
                        Console.ResetColor();
                    }
                } while (!validNumber);
            }

            //Sortiere User-Zahlen
            Array.Sort(userNumbers);

            //Gebe die Vorhersage aus
            Console.Write($"\n\n\tDeine Vorhersage:");
            foreach (int uz in userNumbers)
            {
                Console.Write($"\t{uz}");
            }

            //Lottozahlen generieren
            //Zufallszahlen erstellen
            Random randomLotto = new Random();

            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                lottoNumbers[i] = randomLotto.Next(1, 50);
                //doppelte Zahlen ausschließen: rückwerts prüfen, ob die Zahl vorhanden ist
                for (int j = i - 1; j >= 0; j--)
                {
                    if (lottoNumbers[j] == lottoNumbers[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            //Sortiere Lottozahlen
            Array.Sort(lottoNumbers);

            //Gebe Lottozahlen aus
            Console.Write($"\n\tGewinnzahlen:\t");
            foreach (int lz in lottoNumbers)
            {
                Console.Write($"\t{lz}");
            }

            //Treffer in array speichern
            for (int i = 0; i < userNumbers.Length; i++)
            {
                for (int j = 0; j < lottoNumbers.Length; j++)
                {
                    if (userNumbers[i] == lottoNumbers[j])
                    {
                        hitNumbers.Add(userNumbers[i]);
                    }
                }
            }


            //Ergebnisse ausgeben
            switch (hitNumbers.Count)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\n\tSchade, du hast leider {hitNumbers.Count} Treffer!");
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\n\tNicht schlecht! Aber... leider nur {hitNumbers.Count} Treffer: {hitNumbers[0]}");
                    Console.ResetColor();
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n\n\tGlückwunsch! Du hast {hitNumbers.Count} Treffer: ");
                    Console.ResetColor();
                    //Treffer ausgeben
                    foreach (int t in hitNumbers)
                    {
                        Console.Write($"\t{t}");
                    }
                    Console.WriteLine();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n\n\t***** JACKPOT!!! Glückwunsch!!! *****");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tEtwas ist schiefgelaufen :(");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\n\tBitte Enter drücken um fortzusetzen");
            Console.ReadLine();
        }
    }
}



//Console.WriteLine("\n\n*** Glücksspiel kann süchtig machen! ***");
