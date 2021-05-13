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
        public List<Card> deck { get; set; } = new List<Card>();
    }
}
