using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using PiramidSolitaire.Piramid;
using PiramidSolitaire.GameLogic;
using System;
using System.Text;

namespace PiramidSolitaire
{
    class Start
    {
                   
        static void Main(string[] args)
        {
            Console.SetWindowSize(140,40);
            Console.OutputEncoding = Encoding.UTF8;

            Deck deck = new Deck();
            PiramidCards piramidCards = new PiramidCards();

            deck.ShuffleDeck();

            piramidCards.Fill(deck);

            PrintGameConsole.PrintGame(piramidCards, deck.getCard(29));

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
