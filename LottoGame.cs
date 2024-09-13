using System.Collections;

namespace Uebung_Lottozahlen;

public class LottoGame
{
    int hitsCount;
    int[] lottoNumbers = new int[6];
    int[] userNumbers = new int[6];
    ArrayList hitNumbers = new ArrayList();

    public int HitsCount { get => hitsCount; set => hitsCount = value; }
    public ArrayList HitNumbers { get => hitNumbers; set => hitNumbers = value; }
    public LottoGame(){}
    public void playLotto()
    {
        askUserForLottoNumbers();
        showUserNumbers();
        generateLottoNumbers();
        showLottoNumbers();
        findHits();
        showHits();
    }
    private void askUserForLottoNumbers()
    {
        bool validNumber = false;
        Console.WriteLine("\tGib bitte 6 Zahlen von 1 bis 49 ein!\n");

        for (int i = 0; i < userNumbers.Length; i++)
        {
            do
            {
                Console.Write($"\tDeine Zahl {i + 1}: ");

                if (int.TryParse(Console.ReadLine(), out userNumbers[i]) && isNumberValide(userNumbers[i]))
                {
                    validNumber = true;
                    if (isNumberDoubled(userNumbers[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\tDeine Zahl ist doppelt!");
                        Console.ResetColor();
                        validNumber = false;
                    }
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
    }
    private bool isNumberDoubled(int number)
    {
        int i = userNumbers.Count(element => element != 0);
        if (i > 1)
        {
            for (int j = i - 2; j >= 0; j--)
            {
                if (userNumbers[j] == number)
                    return true;
                continue;
            }
        }
        return false;
    }
    private bool isNumberValide(int number)
    {
        if (number > 0 && number <= 49)
            return true;
        return false;
    }
    private void showUserNumbers()
    {
        Array.Sort(userNumbers);
        Console.Write($"\n\n\tDeine Vorhersage:");
        printNumbersInLine(userNumbers);
    }
    private void printNumbersInLine(int[] numbers)
    {
        foreach (int n in numbers)
        {
            Console.Write($"\t{n}");
        }
    }
    private void generateLottoNumbers()
    {
        Random randomLotto = new Random();
        for (int i = 0; i < lottoNumbers.Length; i++)
        {
            lottoNumbers[i] = randomLotto.Next(1, 50);
            //Exclude duplicate numbers: check backwards whether the number is already exists
            for (int j = i - 1; j >= 0; j--)
            {
                if (lottoNumbers[j] == lottoNumbers[i])
                {
                    i--;
                    break;
                }
            }
        }
    }
    private void showLottoNumbers()
    {
        Array.Sort(lottoNumbers);
        Console.Write($"\n\tGewinnzahlen:\t");
        printNumbersInLine(lottoNumbers);
    }
    private void findHits()
    {
        for (int i = 0; i < userNumbers.Length; i++)
        {
            for (int j = 0; j < lottoNumbers.Length; j++)
            {
                if (userNumbers[i] == lottoNumbers[j])
                {
                    HitNumbers.Add(userNumbers[i]);
                }
            }
        }
    }
    private void showHits()
    {
        //Ergebnisse ausgeben
        switch (HitNumbers.Count)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n\tSchade, du hast leider {HitNumbers.Count} Treffer!");
                Console.ResetColor();
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\n\tNicht schlecht! Aber... leider nur {HitNumbers.Count} Treffer: {HitNumbers[0]}");
                Console.ResetColor();
                break;
            case 2:
            case 3:
            case 4:
            case 5:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n\n\tGlückwunsch! Du hast {HitNumbers.Count} Treffer: ");
                Console.ResetColor();
                //Treffer ausgeben
                foreach (int t in HitNumbers)
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
    }
}



