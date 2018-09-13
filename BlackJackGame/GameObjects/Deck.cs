using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        private int _topCard = 0;
        private Random _rand = new Random();

        // Create a deck of 52 cards that uses all cards once 
        public Deck()
        {
            // Loop for the suit of the card
            for (int s = 0; s < 4; s++)
            {
                // The faceValue loop
                for (int fv = 1; fv <= 13; fv++)
                {
                    _cards.Add(new Card((Suit)s, (FaceValue)fv));
                }
            }
            // Shuffle the deck before using it
            Shuffle();
        }

        public void Shuffle()
        {
            const int traversals = 25;

            // Outer loop is the number of times to traverse the deck
            for (int i = 0; i < traversals; i++)
            {
                // Inner loop that traverses the deck
                for (int j = 0; j < _cards.Count; j++)
                {
                    int cardToSwapWith = _rand.Next(0, _cards.Count);

                    // Swap and save the current card
                    Card temp = _cards[j];
                    _cards[j] = _cards[cardToSwapWith];
                    _cards[cardToSwapWith] = temp;
                }
            }

            _topCard = 0;
        }

        public Card NextCard()
        {
            Card cardToReturn = null;

            // If it gets near the end shuffle the deck again
            if (this._topCard >= _cards.Count - 20)
            {
                Shuffle();
            }
            cardToReturn = _cards[_topCard];
            _topCard++;

            return cardToReturn;
        }
    }
}

