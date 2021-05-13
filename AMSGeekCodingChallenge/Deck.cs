using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Deck
    {
        //Created a Deck object with a list of cards property, which is just a list of previously created Card objects.
        public List<Card> cards { get; set; } = new List<Card>();
        
        //Deck object constructor to create a list of card objects in face value order.
        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    var card = new Card();
                    card.suit = suit;
                    card.face = face;
                    this.cards.Add(card);
                }
            }
        }
        //Shuffle method to randomly permute the created deck of cards.
        public void shuffle()
        {
            var randomNumber = new Random();
            for (int i = cards.Count() - 1; i > 0; i--)
            {
                //Fisher-Yates shuffle algorithm where the current card is replaced with a random card within the deck of cards.
                int j = randomNumber.Next(0, i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            Console.WriteLine("Shuffled deck.");
        }
        //Overloaded shuffle method to shuffle the deck a certain amount of times specified by the argument.
        public void shuffle(int timesToShuffle)
        {
            while (timesToShuffle > 0)
            {
                shuffle();
                timesToShuffle--;
            }
        }
        //Method to deal one card (and remove that card from the deck) from a certain deck specified by the argument.
        public void dealOneCard() 
        {
            //Checks if there are any remaining cards in the deck before dealing a card.
            if (cards.Count() > 0)
            {
                var card = cards[0];
                Console.WriteLine($"Card dealt: \n{card.face} of {card.suit}\n");
                cards.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("There are no more cards to be dealt!");
            }


        }
        //Overloaded dealOneCard method to deal a certain amount of cards from the deck specified by the argument.
        public void dealOneCard(int cardsToDeal)
        {
            if (cardsToDeal <= cards.Count())
            {
                Console.WriteLine("Cards dealt: ");
                while (cardsToDeal > 0)
                {
                    Console.WriteLine($"{cards[0].face} of {cards[0].suit}");
                    cards.RemoveAt(0);
                    if (cardsToDeal == 1) Console.WriteLine();
                    cardsToDeal--;
                }
            }
            else
            {
                Console.WriteLine("There are no more cards to be dealt!");
            }


        }
        //Deals all of the remaining cards in the deck.
        public void dealAllCards()
        {
            if (cards.Count() > 0)
            {
                for (int i = cards.Count(); i > 0; i--)
                {
                    dealOneCard();
                }
            }
            else
            {
                Console.WriteLine("There are no more cards to be dealt!");
            }
            
        }
    }
}
