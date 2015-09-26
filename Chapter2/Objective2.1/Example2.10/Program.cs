using System;
using System.Collections.Generic;
using System.Linq;

namespace Example2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardCollection = new List<Card>();
            Deck.NumberOfCards = 10;
            for (int i = 0; i < Deck.NumberOfCards; i++)
            {
                cardCollection.Add(new Card{ Number = i });
            }

            Deck deck = new Deck(cardCollection);
            var firstCard = deck[0];
            Console.WriteLine("First card's number in the Deck object is: {0}", firstCard.Number);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Card
    {
        public int Number { get; set; }
    }

    class Deck
    {
        public static int NumberOfCards = 42;
        public Deck(ICollection<Card> cards)
        {
            this.Cards = cards;
        }

        public ICollection<Card> Cards { get; private set; }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }
}
