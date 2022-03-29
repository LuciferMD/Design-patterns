using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using PiramidSolitaire.Piramid;
using PiramidSolitaire.GameLogic;
using System;


namespace PiramidSolitaire.GameLogic
{
    public static class MainController
    {
        public static byte ClickButton()
        {
            while (true)
            {
                ConsoleKeyInfo ki = Console.ReadKey(true); //click on a button

                switch (ki.Key)
                {
                    case ConsoleKey.Oem3:
                        return 0;
                    case ConsoleKey.NumPad1:
                        return 1;
                    case ConsoleKey.NumPad2:
                        return 2;
                    case ConsoleKey.NumPad3:
                        return 3;
                    case ConsoleKey.NumPad4:
                        return 4;
                    case ConsoleKey.NumPad5:
                        return 5;
                    case ConsoleKey.NumPad6:
                        return 6;
                    case ConsoleKey.NumPad7:
                        return 7;
                    case ConsoleKey.Enter: //another card  
                        return 8;
                    default:
                        break;
                }
            }
            

        }
    }
}
