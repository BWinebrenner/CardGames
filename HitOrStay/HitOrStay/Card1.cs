using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card1
{
    public class Card
    {
        public enum SUITVALUE { spades, hearts, clubs, dimaonds }
        public enum FACEVALUE { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace }
        private FACEVALUE faceValue;
        private SUITVALUE suitValue;


        public Card(FACEVALUE faceValue, SUITVALUE suitValue)
        {
            this.faceValue = faceValue;
            this.suitValue = suitValue;
        }

        public FACEVALUE getFaceValue()
        {
            return faceValue;
        }

        public SUITVALUE getSuitValue()
        {
            return suitValue;
        }


        public override string ToString()
        {
            return this.faceValue + "of" + this.suitValue;
        }
    }
}
