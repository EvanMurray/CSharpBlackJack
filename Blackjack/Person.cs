using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Person
    {
        public List<Card> Hand { get; set; }
        public int Score { get; set; }

        public Person()
        {
            Hand = new List<Card>();
        }
    }
}
