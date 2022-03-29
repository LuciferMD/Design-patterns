using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using PiramidSolitaire.Piramid;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiramidSolitaire.GameLogic
{

    public static class PrintGameConsole
    {
        public static void PrintGame(PiramidCards piramidCards, Card card)
        {
            card.PrintCardConsole();

            Console.SetCursorPosition(Console.WindowWidth/2,1);


            for (int y = 0; y <= piramidCards.Length-1; y++)
            { 
                for (int x = 0; x <= y; x++)
                {
                    piramidCards.getCard(y, x)?.PrintCardConsole();
                }
                y ++;
                Console.CursorLeft = Console.WindowWidth / 2 - y * 8;
                Console.CursorTop +=  4;
                y--;
               
            }

        }

    }
}
