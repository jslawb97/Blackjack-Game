using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Card
    {
        public Suit suit { get; private set; }
        public FaceValue faceValue { get; private set; }

        public Card(Suit suit, FaceValue faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
        }

        public string ImageName
        {
            get
            {
                return (Enum.GetName(typeof(FaceValue), this.faceValue) +
                    "_of_" +
                    Enum.GetName(typeof(Suit), this.suit)).ToLower();
            }
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(FaceValue), this.faceValue) +
                " of " +
                Enum.GetName(typeof(Suit), this.suit);
        }

        public int PointValue
        {
            get
            {
                if ((int)this.faceValue <= 10)
                {
                    return (int)this.faceValue;
                }
                else
                {
                    return 10;
                }
            }
        }
    }
}
