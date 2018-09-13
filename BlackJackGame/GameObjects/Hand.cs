using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Hand
    {
        public Card[] Cards { get; private set; }
        public bool[] Keep { set; get; }

        // Assigns the cards to there indexes
        public Hand(Card a, Card b, Card c, Card d, Card e, Card f, Card g, Card h)
        {
            this.Cards = new Card[8];
            this.Keep = new bool[8];

            this.Cards[0] = a;
            this.Cards[1] = b;
            this.Cards[2] = c;
            this.Cards[3] = d;

            this.Cards[4] = e;
            this.Cards[5] = f;
            this.Cards[6] = g;
            this.Cards[7] = h;

            for (int i = 0; i < Keep.Length; i++)
            {
                Keep[i] = false;
            }
        }

        // Gets the value of the players first two cards
        public HandValue ScoreHand()
        {
            HandValue result = HandValue.Nothing;
            int result2 = 0;

            // If the first two cards are an ace and face card the
            // score is automatically set to 21
            if (Cards[0].faceValue == FaceValue.Ace &&
                (Cards[1].faceValue == FaceValue.Ten ||
                Cards[1].faceValue == FaceValue.Jack ||
                Cards[1].faceValue == FaceValue.Queen ||
                Cards[1].faceValue == FaceValue.King))
            {
                result = HandValue.TwentyOne;
            }
            else if (Cards[1].faceValue == FaceValue.Ace &&
            (Cards[0].faceValue == FaceValue.Ten ||
            Cards[0].faceValue == FaceValue.Jack ||
            Cards[0].faceValue == FaceValue.Queen ||
            Cards[0].faceValue == FaceValue.King))
            {
                result = HandValue.TwentyOne;
            }
            else if (Cards[0].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[0].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[0].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[0].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[0].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[0].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[0].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[0].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[0].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }

            // Gets the value of the second cards and adds them together
            if (result == HandValue.TwentyOne)
            {
                result2 = 0;
            }
            else if (Cards[1].faceValue == FaceValue.Ace)
            {
                result2 = (int)HandValue.Ace;
            }
            else if (Cards[1].faceValue == FaceValue.Two)
            {
                result2 = (int)HandValue.Two;
            }
            else if (Cards[1].faceValue == FaceValue.Three)
            {
                result2 = (int)HandValue.Three;
            }
            else if (Cards[1].faceValue == FaceValue.Four)
            {
                result2 = (int)HandValue.Four;
            }
            else if (Cards[1].faceValue == FaceValue.Five)
            {
                result2 = (int)HandValue.Five;
            }
            else if (Cards[1].faceValue == FaceValue.Six)
            {
                result2 = (int)HandValue.Six;
            }
            else if (Cards[1].faceValue == FaceValue.Seven)
            {
                result2 = (int)HandValue.Seven;
            }
            else if (Cards[1].faceValue == FaceValue.Eight)
            {
                result2 = (int)HandValue.Eight;
            }
            else if (Cards[1].faceValue == FaceValue.Nine)
            {
                result2 = (int)HandValue.Nine;
            }
            else
            {
                result2 = (int)HandValue.Ten;
            }


            return result + result2;
        }

        // Gets the value of the players third card
        public HandValue ScoreNextCard()
        {
            HandValue result = HandValue.Nothing;
            if (Cards[2].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[2].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[2].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[2].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[2].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[2].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[2].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[2].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[2].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }
            int value = (int)ScoreHand();

            return result + value;
        }

        // Gets the value of the players fourth card
        public HandValue ScoreLastCard()
        {
            HandValue result = HandValue.Nothing;
            if (Cards[3].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[3].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[3].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[3].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[3].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[3].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[3].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[3].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[3].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }
            int value = (int)ScoreNextCard();

            return result + value;
        }

        // Gets the value of the dealers first two cards
        public HandValue ScoreDealerHand()
        {
            HandValue result = HandValue.Nothing;
            int result2 = 0;

            // If the first two cards are an ace and face card the
            // score is automatically set to 21
            if (Cards[4].faceValue == FaceValue.Ace &&
               (Cards[5].faceValue == FaceValue.Ten ||
                Cards[5].faceValue == FaceValue.Jack ||
                Cards[5].faceValue == FaceValue.Queen ||
                Cards[5].faceValue == FaceValue.King))
            {
                result = HandValue.TwentyOne;
            }
            else if (Cards[5].faceValue == FaceValue.Ace &&
                    (Cards[4].faceValue == FaceValue.Ten ||
                     Cards[4].faceValue == FaceValue.Jack ||
                     Cards[4].faceValue == FaceValue.Queen ||
                     Cards[4].faceValue == FaceValue.King))
            {
                result = HandValue.TwentyOne;
            }
            else if (Cards[4].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[4].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[4].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[4].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[4].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[4].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[4].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[4].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[4].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }

            // Gets the value of the second card and adds it together
            if (result == HandValue.TwentyOne)
            {
                result2 = 0;
            }
            else if (Cards[5].faceValue == FaceValue.Ace)
            {
                result2 = (int)HandValue.Ace;
            }
            else if (Cards[5].faceValue == FaceValue.Two)
            {
                result2 = (int)HandValue.Two;
            }
            else if (Cards[5].faceValue == FaceValue.Three)
            {
                result2 = (int)HandValue.Three;
            }
            else if (Cards[5].faceValue == FaceValue.Four)
            {
                result2 = (int)HandValue.Four;
            }
            else if (Cards[5].faceValue == FaceValue.Five)
            {
                result2 = (int)HandValue.Five;
            }
            else if (Cards[5].faceValue == FaceValue.Six)
            {
                result2 = (int)HandValue.Six;
            }
            else if (Cards[5].faceValue == FaceValue.Seven)
            {
                result2 = (int)HandValue.Seven;
            }
            else if (Cards[5].faceValue == FaceValue.Eight)
            {
                result2 = (int)HandValue.Eight;
            }
            else if (Cards[5].faceValue == FaceValue.Nine)
            {
                result2 = (int)HandValue.Nine;
            }
            else
            {
                result2 = (int)HandValue.Ten;
            }
            return result + result2;
        }

        // Gets the value of the dealers third card
        public HandValue ScoreDealerNextCard()
        {
            HandValue result = HandValue.Nothing;
            if (Cards[6].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[6].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[6].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[6].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[6].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[6].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[6].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[6].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[6].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }
            int value = (int)ScoreDealerHand();

            return result + value;
        }

        // Gets the value of the dealers fourth card
        public HandValue ScoreDealerLastCard()
        {
            HandValue result = HandValue.Nothing;
            if (Cards[7].faceValue == FaceValue.Ace)
            {
                result = HandValue.Ace;
            }
            else if (Cards[7].faceValue == FaceValue.Two)
            {
                result = HandValue.Two;
            }
            else if (Cards[7].faceValue == FaceValue.Three)
            {
                result = HandValue.Three;
            }
            else if (Cards[7].faceValue == FaceValue.Four)
            {
                result = HandValue.Four;
            }
            else if (Cards[7].faceValue == FaceValue.Five)
            {
                result = HandValue.Five;
            }
            else if (Cards[7].faceValue == FaceValue.Six)
            {
                result = HandValue.Six;
            }
            else if (Cards[7].faceValue == FaceValue.Seven)
            {
                result = HandValue.Seven;
            }
            else if (Cards[7].faceValue == FaceValue.Eight)
            {
                result = HandValue.Eight;
            }
            else if (Cards[7].faceValue == FaceValue.Nine)
            {
                result = HandValue.Nine;
            }
            else
            {
                result = HandValue.Ten;
            }
            int value = (int)ScoreDealerNextCard();

            return result + value;
        }

    }
}
