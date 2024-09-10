namespace Uebung_Lottozahlen;

internal static class Title
{
    public static void PrintTitle()
    {
        Console.WriteLine("\n\n");

        //Erste Zeile fast komplett in Farbe DarkGray
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("\n\t:");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(":         ::::::::  ::::");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("  ::::: :::::  ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("::::  ::::::::");

        //Zweite Zeile: manche Zeichen sind in Farbe Gray
        Console.Write("\n\t:+:        :+:    ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("+:     :+:           ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(":     :+:    :+:");
        Console.ResetColor();

        //Dritte Zeile: mehr und mehr Zeichen in Frabe Gray
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("\n\t+:");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("        +:+    ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("     +:+           ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("     +:+    ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(":");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+");

        //Vierte Zeile: weniger DarkGray, mehr Gray
        Console.Write("\n\t+:+        +:+    ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(":+     +#+           ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("#+     +:+    +:");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("+");
        Console.ResetColor();

        //Fünfte Zeile: noch weniger DarkGray, meistens Gray, einzelne Zeichen in Farbe White
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("\n\t+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("#+        +#+    +");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("#");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+     +#+           ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("+");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("#");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("+     +#+    +#");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("+");


        //Sechste Zeile: gemischt White und Gray
        Console.Write("\n\t#+#        #+#    ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("#+#     #+#");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("           #+#     #+#    ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("#+#");
        Console.ResetColor();

        //Siebte zeile komplett in White
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n\t ########   ########      ###           ###      ########\n");
        Console.ResetColor();

        Console.WriteLine("\t__________________________________________________________");
        Console.WriteLine("\n\n");
    }
}
