using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        public string suit;
        public string rank;
        // now I need the card constructor, but I can't remember how to pull this off.
        public Card(string rank, string suit)
        {
            //now I know I need to call the "this.card" but I don't know why or how.
            // I had to look at the example because I couldn't remember the syntax at all.
            // Turns out I need to use "this.rank" and "this.suit". I think this is so I can 
            // tell the "Public Card" what to use when I state "rank,suit" in it's definition.
            this.rank = rank;
            this.suit = suit;
            // return $"{this.rank} of {this.suit}";
            // I tried to see what would happen if did this. 

        }

        override public string ToString()
        {
            return $"{this.rank} of {this.suit}";
            // Not sure why we did this, but when I tried the "return" above, it told me "Card.Card" returns void 
            // and an object cannot follow. I notice the "ToString" references 'Card.ToString' so maybe we're giving 
            // it something to replace 'void'?
        }



    }
    public class Deck
    {
        public List<Card> cards; // A new list of the "Card" class named 'cards'

        public Deck()
        { // This is the Deck constructor. So we need a list of cards.
          // Each card needs to be built from a rank and suit- like we did in our last program.


            this.cards = new List<Card>();
            var suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamonds" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    this.cards.Add(new Card(rank, suit)); // Ok, I had to peek for this one, too.
                }
            }
        }


    }
}
class Program
{
    static void Main(string[] args)
    {
        // I'm trying to recall the "AllCardsOnDeck" assignment to see if this helps me with this program.
        //     var suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamonds" };
        //     var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        //     var deck = new List<string>();
        //     foreach (var suit in suits)
        //     {
        //         foreach (var rank in ranks)
        //         {

        //             deck.Add($"{rank} of {suit}");
        //         }
        //     }
        //     Console.WriteLine($"{deck[0]},  {deck[1]}");


    }
}
}
