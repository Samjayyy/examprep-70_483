using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(5);
        }
    }

    class Card
    {

    }

    class Deck
    {
        private int maximumNumberOfCards;

        public List<Card> Cards { get; set; }

        public Deck(int maximumNumberOfCards)
        {
            this.maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }
    }
}
