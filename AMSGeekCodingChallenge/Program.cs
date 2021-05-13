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
        public static void shuffle(Deck deck)
        {
            var randomNumber = new Random();
            for (int i = deck.deck.Count() - 1; i > 0; i--)
            {
                int j = randomNumber.Next(0, i + 1);
                var temp = deck.deck[i];
                deck.deck[i] = deck.deck[j];
                deck.deck[j] = temp;
            }
        }
        public static void shuffle(Deck deck, int timesToShuffle)
        {
            while (timesToShuffle > 0)
            {
                shuffle(deck);
                timesToShuffle--;
            }
        }
        public static Card dealOneCard(Deck deck)
        {
            if (deck.deck.Count() > 0)
            {
                var cardToReturn = deck.deck[0];
                Console.WriteLine($"Card dealt: {cardToReturn.face} of {cardToReturn.suit}");
                deck.deck.RemoveAt(0);
                return cardToReturn;
            }
            else
            {
                return null;
            }
            
            
        }
        public static Deck dealOneCard(Deck deck, int cardsToDeal)
        {
            if (cardsToDeal <= deck.deck.Count())
            {
                while (cardsToDeal >= deck.deck.Count())
                {
                    dealOneCard(deck);
                    cardsToDeal--;
                    
                }
                return deck;
            }
            else
            {
                return null;
            }
            

        }
        
        
        
        static void Main(string[] args)
        {
            var deck = createDeck();
            var dealt = new DealtCard();
            shuffle(deck, 3);
            
            
            try
            {
                dealt.dealtCard.Add(dealOneCard(deck));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("There are no more cards to be dealt from that deck!");
            }









            //foreach (Card card in deck.deck)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();

            //TEST FOR UNORGANIZED LIST OF CARDS

            //ADD TESTS FOR EACH METHOD
            //ADD TEST FOR FINAL RUN THROUGH

        }
    }
}
