using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Computer
    {
        private int cardsInHand;

        public Computer( int cardInHand)
        {
            this.cardsInHand = cardsInHand;

        }

        public int getCardInHand()
        {
            return cardsInHand;
        }

        //public int setCardInHand()
        //{

        //}
    }
}
