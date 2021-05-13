using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSGeekCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.shuffle();
            deck.dealAllCards();
            deck.dealOneCard();
            Console.ReadLine();



            //TEST for unorganized list of cards
            //-----------------------------------------------------
            //foreach (var card in deck.cards)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();


            //TEST for shuffled list of cards AND shuffled ? times
            //-----------------------------------------------------
            //deck.shuffle();
            //foreach (var card in deck.cards)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();
            //-----------------------------------------------------
            //deck.shuffle(3);
            //foreach (var card in deck.cards)
            //{
            //    Console.WriteLine($"{card.face} of {card.suit}");
            //}
            //Console.ReadLine();


            //TEST for one dealt card AND one dealt card with no remaining cards in deck
            //-----------------------------------------------------
            //deck.dealOneCard();
            //deck.cards.RemoveRange(0, deck.cards.Count());
            //deck.dealOneCard();
            //Console.ReadLine();


            //TEST for multiple dealt cards AND multiple dealt cards with no remaining cards in deck
            //-----------------------------------------------------
            //deck.dealOneCard(5);
            //deck.cards.RemoveRange(0, deck.cards.Count());
            //deck.dealOneCard(5);
            //Console.ReadLine();


            //TEST to deal all of the remaining cards in the deck
            //-----------------------------------------------------
            //deck.dealAllCards();
            //deck.dealAllCards();
            //Console.ReadLine();
        }
    }
}
