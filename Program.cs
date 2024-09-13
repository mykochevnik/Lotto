using Uebung_Lottozahlen;
internal class Program
{
    private static void Main(string[] args)
    {
        startProgram();
    }
    public static void startProgram()
    {
        bool exit = false;
        do
        {
            showMenu();
            exit = validateAndExecuteMenuSelection();

        } while (!exit);
    }
    private static void showMenu()
    {
        Title.PrintTitle();
        Console.WriteLine("\tWähle aus:\n");
        Console.WriteLine("\t\t1 '6 aus 49' spielen");
        Console.WriteLine("\t\t2 Statistik anzeigen");
        Console.WriteLine("\t\t3 Beenden");
    }
    //if there is nothing to execute, return false
    private static bool validateAndExecuteMenuSelection()
    {
        bool validInput = false, exit;
        int userInput;
        LottoGame game;
        do
        {
            exit = false;
            Console.Write("\n\tDeine Entscheidung: ");

            validInput = int.TryParse(Console.ReadLine(), out userInput);
            switch (userInput)
            {
                case 1:
                    Title.PrintTitle();
                    game = new LottoGame();
                    game.playLotto();
                    Console.WriteLine("\n\tBitte Enter drücken um fortzusetzen");
                    Console.ReadLine();
                    exit = false;
                    validInput = true;
                    break;
                case 2:
                    Title.PrintTitle();
                    showStatistic();
                    Console.WriteLine("\n\tBitte Enter drücken um fortzusetzen.");
                    Console.ReadLine();
                    exit = false;
                    validInput = true;
                    break;
                case 3:
                    validInput = true;
                    exit = true;
                    break;
                default:
                    validInput = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t\tUngültige Option.");
                    Console.ResetColor();
                    break;
            }
        } while (!validInput);
        return exit;
    }
    private static void showStatistic()
    {
        Console.WriteLine("\n\tAnzahl der erratenen Zahlen als Prozentsatz. Noch in Bearbeitung ... ");
    }
}


//Console.WriteLine("\n\n*** Glücksspiel kann süchtig machen! ***");
