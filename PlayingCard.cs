using System;
using System.Collections.Generic;

namespace Poker
{
    class PlayingCard
    {
        protected List<string> SUITS_LIST = new List<string>() {"Пик", "Бубен", "Черв", "Треф"};
        protected List<string> RANK_LIST = new List<string>() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Королева", "Король", "Туз"};
        protected String suit;
        protected String rank;
        public PlayingCard(String suit, String rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public string Rank { set { rank = value; } get { return rank; } }
        public string Suit { set { suit = value; } get { return suit; } }
        public String toString()
        {
            return rank + " " + suit;
        }
    }
}
