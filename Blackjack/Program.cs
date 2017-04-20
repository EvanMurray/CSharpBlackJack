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

            List<Card> deck = new List<Card>(52);

            populateDeck(deck);

            //dealer
            Person dealer = new Person();
            //player

            Person player = new Person();

            game(deck, player, dealer);
            //hit or pass
            //win condition
            
         }
        
       private static void game(List<Card> deck, Person player, Person dealer)
        {
            
            bool isPlayersTurn = true;
            bool isDealersTurn = false;
            
            Random rand = new Random();

            while (true)
            {
                if(isPlayersTurn)
                {
                    
                    if (player.Hand.Count == 0)
                    {
                        addPlayerCard(deck, player, rand);
                        addPlayerCard(deck, player, rand);
                    }
                    else
                    {
                        addPlayerCard(deck, player, rand);
                    }
                    
                    Console.WriteLine("Player Score: " + player.Score);
                    if(player.Score > 21)
                    {
                        Console.WriteLine("You've Lost!");
                        break;
                    }
                    Console.WriteLine("1: Hit || 2: Stay ");
                    int hit = int.Parse(Console.ReadLine());
                    if(hit == 1)
                    {
                        continue;
                    }
                    else if(hit == 2)
                    {
                        isPlayersTurn = false;
                        isDealersTurn = true;
                    }
                    
                }
                else if(isDealersTurn)
                {
                    Card c = deck[rand.Next(deck.Count)];
                    dealer.Hand.Add(c);
                    deck.Remove(c);
                    dealer.Score += c.Score;
                    Console.WriteLine("Dealer Score: " + dealer.Score);
                    if (dealer.Score < 16)
                    {
                        continue;
                    }
                    else if (dealer.Score >= 16 && dealer.Score <= 21)
                    {
                        if (dealer.Score >= player.Score)
                        {
                            Console.WriteLine("You Lose!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You won!");
                        break;
                    }   
                }  
            }     
        }

       private static void addPlayerCard(List<Card> deck, Person player, Random rand)
        {
            Card c = deck[rand.Next(deck.Count)];
            player.Hand.Add(c);
            Console.WriteLine("Card: " + c.Face);
            deck.Remove(c);
            player.Score += c.Score;
        }

        private static void populateDeck(List<Card> deck)
        {
            int count = 0;

            for(int suit = 1; suit <= 4; suit ++)
            {      

                for(int value = 1; value <= 13; value ++)
                {
                    if(suit == 1)
                    {
                        deck.Add(new Card() {Suit = "Spades", Value = value });
                        deck[count].setScore();
                        count++;
                    }
                    else if (suit == 2)
                    {
                        deck.Add(new Card() { Suit = "Clubs", Value = value });
                        deck[count].setScore();
                        count++;
                    }
                    else if (suit == 3)
                    {
                        deck.Add(new Card() { Suit = "Diamonds", Value = value });
                        deck[count].setScore();
                        count++;
                    }
                    else if (suit == 4)
                    {
                        deck.Add(new Card() { Suit = "Hearts", Value = value });
                        deck[count].setScore();
                        count++;
                    }
                }
            }
        }
    }
}
