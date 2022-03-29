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
            Console.SetWindowSize(150,40);
            Console.OutputEncoding = Encoding.UTF8;


            Deck deck = new Deck();   // Create deck
            PiramidCards piramidCards = new PiramidCards();  //create piramide cards

            deck.ShuffleDeck(); //shuffle deck

            piramidCards.Fill(deck); // put first 28 cards into piramide

            SelectedCouple selectedCouple = new();

            int counter = 29;

           
            PrintGameConsole.PrintGame(piramidCards, deck.getCard(counter)); //print first screen

           
            while (true)
            {
                byte button = MainController.ClickButton();

                switch (button)
                {
                    case 0:
                        selectedCouple.add(deck.getCard(counter)); //Add card from deck to sum with second card
                        if (selectedCouple.check())
                        {                      
                            deck.setCard(counter, null);
                        }
                        break;
                    case 1:
                        //piramidCards.getCard()
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8: //another card
                        if (counter == 51) {counter = 29; }  //end deck              
                        else { counter++; }
                        while (deck.getCard(counter)==null)
                        {
                            counter++;
                        }
                        Console.Clear(); 
                        break;
                    default:
                        break;
                }
               
              PrintGameConsole.PrintGame(piramidCards, deck.getCard(counter)); //print first screen
                    
                //Console.Clear();
            }
                

            
        }
    }
}
