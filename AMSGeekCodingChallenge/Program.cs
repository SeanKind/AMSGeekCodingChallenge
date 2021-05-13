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
                var tempDeck = new Deck();
                Console.WriteLine("Cards dealt: ");
                while (cardsToDeal > 0)
                {
                    tempDeck.deck.Add(deck.deck[0]);
                    Console.WriteLine($"{deck.deck[0].face} of {deck.deck[0].suit}");
                    deck.deck.RemoveAt(0);
                    cardsToDeal--;
                }
                return tempDeck;
            }
            else
            {
                return null;
            }
            

        }
        public static List<Card> deckToDealtDeck(Deck deck, List<Card> dealtDeck)
        {
            if (deck != null) 
            {
                foreach (var card in deck.deck)
                {
                    dealtDeck.Add(card);
                    deck.deck.Remove(card);
                } 
            }
            return dealtDeck;
        }
        
        
        
        static void Main(string[] args)
        {
            var deck = createDeck();
            var dealtDeck = new DealtCardDeck();
            shuffle(deck);
            dealtDeck.dealtCard.Add(dealOneCard(deck));

            deckToDealtDeck(dealOneCard(deck, 10), dealtDeck.dealtCard);
            Console.ReadLine();
            
            
            
            
            
            //shuffle(deck, 3);
            //try
            //{
            //    dealt.dealtCard.Add(dealOneCard(deck));
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("There are no more cards to be dealt from that deck!");
            //}
            //foreach (Card card in deck.deck)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();

            //TEST FOR UNORGANIZED LIST OF CARDS

            //ADD TESTS FOR EACH METHOD
            //ADD TEST FOR FINAL RUN THROUGH
            //COMMENT AND DOCUMENT

        }
    }
}
