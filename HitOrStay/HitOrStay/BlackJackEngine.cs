using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deck1;
using Card1;

namespace HitOrStay
{
    public class BlackJackEngine
    {
        private static Deck playing = new Deck();
        public static void Gamestart()
        {
            playing.Shuffle();

        }
        public static Card Hit()
        {
            Card delt = playing.Dealer();
            return delt;
        }
        public static void Stay()
        {

        }
        public static void AI()
        {

        }
        public static void Player()
        {
            int cardtotal = 0;

        }
    }
}
