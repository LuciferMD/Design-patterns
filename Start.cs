using PiramidSolitaire.Cards;
using PiramidSolitaire.DeckSpace;
using System;
using System.Text;

namespace PiramidSolitaire
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Deck deck = new Deck();

            deck.ShuffleDeck();

            for (int i = 10; i < 51; i++)
            {

                deck.getCard(i).PrintCardConsole();

            }
            

           

        }
    }
}
