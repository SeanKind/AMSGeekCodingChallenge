using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Program
    {
        public static Deck createDeck()                                     //Creating a card for each real world card in a standard 52 card deck.
        {
            Deck cardDeck = new Deck();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    var card = new Card();
                    card.suit = suit;
                    card.face = face;
                    cardDeck.deck.Add(card);
                }
            }
            return cardDeck;
        }
        public static void shuffle(Deck deck)                           //Shuffle method to randomly permute the previously created deck of cards.
        {
            var randomNumber = new Random();
            for (int i = deck.deck.Count() - 1; i > 0; i--)
            {
                int j = randomNumber.Next(0, i + 1);                    //Fisher-Yates shuffle algorithm where the current card is replaced with a random card within the deck of cards.
                var temp = deck.deck[i];
                deck.deck[i] = deck.deck[j];
                deck.deck[j] = temp;
            }
            Console.WriteLine("Shuffled deck.");
        }
        public static void shuffle(Deck deck, int timesToShuffle)       //Overloaded shuffle method to shuffle the deck a certain amount of times specified by the argument.
        {
            while (timesToShuffle > 0)
            {
                shuffle(deck);
                timesToShuffle--;
            }
        }
        public static void dealOneCard(Deck deck)                       //Method to deal one card (and remove that card from the deck) from a certain deck specified by the argument. 
        {
            if (deck.deck.Count() > 0)                                  //Checks if there are any remaining cards in the deck before dealing a card.
            {
                var card = deck.deck[0];
                Console.WriteLine($"Card dealt: \n{card.face} of {card.suit}\n");
                deck.deck.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("There are no more cards to be dealt!");
            }
            
            
        }
        public static void dealOneCard(Deck deck, int cardsToDeal)      //Overloaded dealOneCard method to deal a certain amount of cards from the deck specified by the argument.
        {
            if (cardsToDeal <= deck.deck.Count())
            {
                Console.WriteLine("Cards dealt: ");
                while (cardsToDeal > 0)
                {
                    Console.WriteLine($"{deck.deck[0].face} of {deck.deck[0].suit}");
                    deck.deck.RemoveAt(0);
                    if (cardsToDeal == 1) Console.WriteLine();
                    cardsToDeal--;
                }
            }
            else
            {
                Console.WriteLine("There are no more cards to be dealt!");
            }
            

        }
        
        
        
        static void Main(string[] args)
        {
            var deck = createDeck();
            shuffle(deck);
            for (int i = deck.deck.Count(); i > 0; i--)
            {
                dealOneCard(deck);
            }
            dealOneCard(deck);
            Console.ReadLine();



            //TEST for unorganized list of cards
            //-----------------------------------------------------
            //foreach (var card in deck.deck)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();


            //TEST for shuffled list of cards AND shuffled ? times
            //-----------------------------------------------------
            //shuffle(deck);
            //foreach (var card in deck.deck)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();
            //-----------------------------------------------------
            //shuffle(deck, 3);
            //foreach (var card in deck.deck)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();


            //TEST for one dealt card AND one dealt card with no remaining cards in deck
            //-----------------------------------------------------
            //dealOneCard(deck);
            //deck.deck.RemoveRange(0, deck.deck.Count());
            //dealOneCard(deck);
            //Console.ReadLine();


            //TEST for multiple dealt cards AND multiple dealt cards with no remaining cards in deck
            //-----------------------------------------------------
            //dealOneCard(deck, 5);
            //deck.deck.RemoveRange(0, deck.deck.Count());
            //dealOneCard(deck, 5);
            //Console.ReadLine();







            //COMMENT AND DOCUMENT

        }
    }
}
