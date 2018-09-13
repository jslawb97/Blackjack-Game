using GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLayer
{
    public class Dealer
    {
        private Deck _deck = new Deck();

        public Card DealCard()
        {
            return _deck.NextCard();
        }

        // Get the description of the card
        public string GetDescription(Hand hand)
        {
            string description = Enum.GetName(typeof(HandValue), hand.ScoreHand());
            return description.Replace("_", " ");
        }

        // Get 8 random cards
        public Hand NewHand()
        {
            _deck.Shuffle();
            return new Hand(DealCard(), DealCard(), DealCard(), DealCard(), DealCard(), DealCard(), DealCard(), DealCard());
        }

        // Randomly draw the 8 cards
        public Hand DrawCards(Hand hand)
        {
            for (int i = 0; i < 8; i++)
            {
                if (hand.Keep[i] == false)
                {
                    hand.Cards[i] = DealCard();
                }
            }

            return hand;
        }

        // Score the players hand with only 2 cards
        public int GetScore(Hand hand)
        {
            return (int)hand.ScoreHand();
        }

        // Score the players hand with 3 cards
        public int GetNextScore(Hand hand)
        {
            return (int)hand.ScoreNextCard();
        }

        // Score the players hand with 4 cards
        public int GetLastScore(Hand hand)
        {
            return (int)hand.ScoreLastCard();
        }

        // Score the dealers hand with only 2 cards
        public int GetDealerScore(Hand hand)
        {
            return (int)hand.ScoreDealerHand();
        }

        // Score the dealers hand with 3 cards
        public int GetDealerNextScore(Hand hand)
        {
            return (int)hand.ScoreDealerNextCard();
        }

        // Score the dealers hand with 4 cards
        public int GetDealerLastScore(Hand hand)
        {
            return (int)hand.ScoreDealerLastCard();
        }

        
    }
}

