using System;


namespace PiramidSolitaire.Cards
{
    //Extension class
    public static class PrintCardsConsole  
    {
        static string printString;
        static int Value;
        static suitVar Suit;

        /// <summary>
        /// Extension class Card fo print card in console
        /// </summary>
        /// <param name="card"></param>
        public static void PrintCardConsole(this Card card)
        {
            Value = card.Value;
            Suit = card.Suit;

            if (Value == 1)
            {
                printString =
                    " V         " +
                    "           " +
                    "           " +
                    "     S     " +
                    "           " +
                    "           " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 2)
            {
                printString =
                    " V         " +
                    "     S     " +
                    "           " +
                    "           " +
                    "           " +
                    "     S     " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 3)
            {
                printString =
                    " V         " +
                    "     S     " +
                    "           " +
                    "     S     " +
                    "           " +
                    "     S     " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 4)
            {
                printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "           " +
                    "           " +
                    "   S   S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 5)
            {
                printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "     S     " +
                    "           " +
                    "   S   S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 6)
            {
                printString =
                    " V         " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 7)
            {
                printString =
                    " V         " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "           " +
                    "   S   S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 8)
            {
                printString =
                    " V         " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "     S     " +
                    "   S   S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 9)
            {
                printString =
                    " V         " +
                    "   S S S   " +
                    "           " +
                    "   S S S   " +
                    "           " +
                    "   S S S   " +
                    "         V ";
                PrintMethod();
            }
            if (Value == 10 || Value == 11 || Value == 12 || Value == 13)
            {
                printString =
                    " V         " +
                    "    S S    " +
                    "     S     " +
                    "  S S S S  " +
                    "     S     " +
                    "    S S    " +
                    "         V ";
                PrintMethod();
            }
        }
        private static void PrintMethod()
        {

            bool hasWrittenFirstNumber = false;
            
            
            switch (Suit)
            {
                case suitVar.Hearts:
                case suitVar.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case suitVar.Clubs:
                case suitVar.Spades:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            for (int i = 0; i < printString.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                if (i % 11 == 0 && i != 0)
                {
                    Console.CursorLeft -= 11;
                    Console.CursorTop += 1;
                }
                if (printString[i] == 'S')
                {
                    switch (Suit)
                    {
                        case suitVar.Hearts:
                            Console.Write('♥');
                            break;
                        case suitVar.Clubs:
                            Console.Write("♣");
                            break;
                        case suitVar.Diamonds:
                            Console.Write("♦");
                            break;
                        case suitVar.Spades:
                            Console.Write("♠");
                            break;
                    }
                    continue;
                }
                else if (printString[i] == 'V')
                {
                    if (Value == 10)
                    {
                        if (hasWrittenFirstNumber == false)
                        {
                            Console.Write(10);
                            hasWrittenFirstNumber = true;
                            i++;
                        }
                        else
                        {
                            Console.CursorLeft--;
                            Console.Write(10);
                        }
                        continue;
                    }
                    else if (Value == 11)
                    {
                        Console.Write("J");
                    }
                    else if (Value == 12)
                    {
                        Console.Write("Q");
                    }
                    else if (Value == 13)
                    {
                        Console.Write("K");
                    }
                    else if (Value == 1)
                    {
                        Console.Write("A");
                    }
                    else
                    {
                        Console.Write(Value);
                    }
                }
                else
                {
                    Console.Write(printString[i]);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
