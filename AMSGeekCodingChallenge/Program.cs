using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Program
    {
        public Deck createDeck()
        {
            Deck deck = new Deck();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                var card = new Card();
                card.suit = suit;
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    card.face = face;
                    deck.deck.Add(card);
                }
            }
            
            return deck;
        }
        
        public static Deck shuffle(Deck deck)
        {
            
            
            return deck;
        }
        
        
        
        static void Main(string[] args)
        {
            //test to see if the deck will print the enum value or the actual name





        }
    }
}
