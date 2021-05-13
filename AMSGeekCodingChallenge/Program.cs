using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Program
    {
        public static Deck createDeck()
        {
            Deck cardDeck = new Deck() { };
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
        
        public static Deck shuffle(Deck deck)
        {
            
            
            return deck;
        }
        
        
        
        static void Main(string[] args)
        {
            //test to see if the deck will print the enum value or the actual name
            var deck = createDeck();
            foreach (Card card in deck.deck)
            {
                Console.WriteLine($"{card.face} of {card.suit}");
            }
            Console.ReadLine();




        }
    }
}
