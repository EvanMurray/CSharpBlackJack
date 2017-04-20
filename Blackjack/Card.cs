using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }
        public int Score { get; set; }


        public void setScore()
        {
            switch(this.Value)
            {
                case 1:
                    Score = 2;
                    Face = "Two";
                    break;
                case 2:
                    Score = 3;
                    Face = "Three";
                    break;
                case 3:
                    Score = 4;
                    Face = "Four";
                    break;
                case 4:
                    Score = 5;
                    Face = "Five";
                    break;
                case 5:
                    Score = 6;
                    Face = "Six";
                    break;
                case 6:
                    Score = 7;
                    Face = "Seven";
                    break;
                case 7:
                    Score = 8;
                    Face = "Eight";
                    break;
                case 8:
                    Score = 9;
                    Face = "Nine";
                    break;
                case 9:
                    Score = 10;
                    Face = "Ten";
                    break;
                case 10:
                    Score = 10;
                    Face = "Jack";
                    break;
                case 11:
                    Score = 10;
                    Face = "Queen";
                    break;
                case 12:
                    Score = 10;
                    Face = "King";
                    break;
                case 13:
                    Score = 11;
                    Face = "Ace";
                    break;
                
                default:
                    Score = 0;
                    break;
            }
        } 
    }
}
