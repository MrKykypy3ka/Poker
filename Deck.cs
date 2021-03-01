using System;

namespace Poker
{
    class Deck : PlayingCard
    {
        int c1 = 0, c2 = 0, k=0;
        PlayingCard[] deck = new PlayingCard[52];//Колодой выступает массив объектов класса карта
        private Deck(string suit, string rank) : base(suit, rank)
        {           
        }
        public Deck()
        {
            for (int k = 0; k < 52; k++)
            {
                deck[k] = new PlayingCard(SUITS_LIST[c1], RANK_LIST[c2]);
                if (c1 == 3) c1 = 0; else c1++;
                if (c2 == 12) c2 = 0; else c2++;
            }
        }
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }
        }
        public void Distribution(int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(deck[k].toString());
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
