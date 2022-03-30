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

            Card card111 = new();
            ref Card reFirstC = ref card111;
           
            while (true)
            {
                byte button = MainController.ClickButton();

                switch (button)
                {
                    case 0://Add card from deck to sum with second card

                        selectedCouple.Add(deck.getCard(counter)) ;  // Add card to compare
                        if (selectedCouple.Check())  // if we added card and complete, delete this card from deck and piramid
                        {                      
                            deck.setCard(counter, null);
                            reFirstC = null;
                        }
                        else  // if no remembered ref on this card 
                        {
                            reFirstC = deck.getRefCard(counter);
                        }

                        if (counter == 51) { counter = 29; }  //end deck              
                        while (deck.getCard(counter) == null)
                        {
                            counter++;
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
                        break;
                    default:
                        break;
                }


                Console.Clear();
                PrintGameConsole.PrintGame(piramidCards, deck.getCard(counter)); //print first screen
                    
                //Console.Clear();
            }
                

            
        }
    }
}
