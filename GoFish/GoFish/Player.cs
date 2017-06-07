using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Player
    {
        private string name;
        private int cardsInHand;

        public Player(String name, int cardInHand)
        {
            this.name = name;
            this.cardsInHand = cardsInHand;

        }
        public string getName()
        {
            return name;
        }

        public int getCardInHand()
        {
            return cardsInHand;
        }


    }
}
