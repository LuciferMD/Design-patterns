using PiramidSolitaire.Cards;
using System;
using System.Text;

namespace PiramidSolitaire
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Card card = new Card();

            card.Suit = suitVar.Clubs;
            card.Value = 2;

            card.PrintCardConsole();

        }
    }
}
