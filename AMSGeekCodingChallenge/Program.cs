using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Program
    {
        public List<Card> createDeck()
        {
            var deck = new Deck();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                var card = new Card();
                card.suit = suit;
            }
            
            return deck;
        }
        
        public static List<Card> shuffle(Deck deck)
        {
            
            
            return deck;
        }
        
        
        
        static void Main(string[] args)
        {
            //test to see if 





        }
    }
}
