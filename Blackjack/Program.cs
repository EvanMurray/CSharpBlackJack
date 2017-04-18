using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //deck of cards

            Card[] deck = new Card[52];

            populateDeck(deck);
            
            //dealer
            //player
            //hit or pass
            //win condition

         }

       

        private static void populateDeck(Card[] deck)
        {
            int count = 0;

            for(int suit = 1; suit <= 4; suit ++)
            {
                

                for(int value = 1; value <= 13; value ++)
                {
                    if(suit == 1)
                    {
                        deck[count] = new Card() {Suit = "Spades", Value = value };
                        count++;
                    }
                    else if (suit == 2)
                    {
                        deck[count] = new Card() { Suit = "Clubs", Value = value };
                        count++;
                    }
                    else if (suit == 3)
                    {
                        deck[count] = new Card() { Suit = "Diamonds", Value = value };
                        count++;
                    }
                    else if (suit == 4)
                    {
                        deck[count] = new Card() { Suit = "Hearts", Value = value };
                        count++;
                    }

                }
            }
        }
    }
}
