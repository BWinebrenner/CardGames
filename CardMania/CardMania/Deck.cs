using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card1;

namespace Decks
{

    public class Deck
    {
        private Card1.Card[] cards = new Card1.Card[52];
        private int l = 0;
        public Deck()
        {


            cards[0] = new Card1.Card(Card1.Card.FACEVALUE.two, Card1.Card.SUITVALUE.spades);
            cards[1] = new Card1.Card(Card1.Card.FACEVALUE.three, Card1.Card.SUITVALUE.spades);
            cards[2] = new Card1.Card(Card1.Card.FACEVALUE.four, Card1.Card.SUITVALUE.spades);
            cards[3] = new Card1.Card(Card1.Card.FACEVALUE.five, Card1.Card.SUITVALUE.spades);
            cards[4] = new Card1.Card(Card1.Card.FACEVALUE.six, Card1.Card.SUITVALUE.spades);
            cards[5] = new Card1.Card(Card1.Card.FACEVALUE.seven, Card1.Card.SUITVALUE.spades);
            cards[6] = new Card1.Card(Card1.Card.FACEVALUE.eight, Card1.Card.SUITVALUE.spades);
            cards[7] = new Card1.Card(Card1.Card.FACEVALUE.nine, Card1.Card.SUITVALUE.spades);
            cards[8] = new Card1.Card(Card1.Card.FACEVALUE.ten, Card1.Card.SUITVALUE.spades);
            cards[9] = new Card1.Card(Card1.Card.FACEVALUE.jack, Card1.Card.SUITVALUE.spades);
            cards[10] = new Card1.Card(Card1.Card.FACEVALUE.queen, Card1.Card.SUITVALUE.spades);
            cards[11] = new Card1.Card(Card1.Card.FACEVALUE.king, Card1.Card.SUITVALUE.spades);
            cards[12] = new Card1.Card(Card1.Card.FACEVALUE.ace, Card1.Card.SUITVALUE.spades);
            cards[13] = new Card1.Card(Card1.Card.FACEVALUE.two, Card1.Card.SUITVALUE.hearts);
            cards[14] = new Card1.Card(Card1.Card.FACEVALUE.three, Card1.Card.SUITVALUE.hearts);
            cards[15] = new Card1.Card(Card1.Card.FACEVALUE.four, Card1.Card.SUITVALUE.hearts);
            cards[16] = new Card1.Card(Card1.Card.FACEVALUE.five, Card1.Card.SUITVALUE.hearts);
            cards[17] = new Card1.Card(Card1.Card.FACEVALUE.six, Card1.Card.SUITVALUE.hearts);
            cards[18] = new Card1.Card(Card1.Card.FACEVALUE.seven, Card1.Card.SUITVALUE.hearts);
            cards[19] = new Card1.Card(Card1.Card.FACEVALUE.eight, Card1.Card.SUITVALUE.hearts);
            cards[20] = new Card1.Card(Card1.Card.FACEVALUE.nine, Card1.Card.SUITVALUE.hearts);
            cards[21] = new Card1.Card(Card1.Card.FACEVALUE.ten, Card1.Card.SUITVALUE.hearts);
            cards[22] = new Card1.Card(Card1.Card.FACEVALUE.jack, Card1.Card.SUITVALUE.hearts);
            cards[23] = new Card1.Card(Card1.Card.FACEVALUE.queen, Card1.Card.SUITVALUE.hearts);
            cards[24] = new Card1.Card(Card1.Card.FACEVALUE.king, Card1.Card.SUITVALUE.hearts);
            cards[25] = new Card1.Card(Card1.Card.FACEVALUE.ace, Card1.Card.SUITVALUE.hearts);
            cards[26] = new Card1.Card(Card1.Card.FACEVALUE.two, Card1.Card.SUITVALUE.clubs);
            cards[27] = new Card1.Card(Card1.Card.FACEVALUE.three, Card1.Card.SUITVALUE.clubs);
            cards[28] = new Card1.Card(Card1.Card.FACEVALUE.four, Card1.Card.SUITVALUE.clubs);
            cards[29] = new Card1.Card(Card1.Card.FACEVALUE.five, Card1.Card.SUITVALUE.clubs);
            cards[30] = new Card1.Card(Card1.Card.FACEVALUE.six, Card1.Card.SUITVALUE.clubs);
            cards[31] = new Card1.Card(Card1.Card.FACEVALUE.seven, Card1.Card.SUITVALUE.clubs);
            cards[32] = new Card1.Card(Card1.Card.FACEVALUE.eight, Card1.Card.SUITVALUE.clubs);
            cards[33] = new Card1.Card(Card1.Card.FACEVALUE.nine, Card1.Card.SUITVALUE.clubs);
            cards[34] = new Card1.Card(Card1.Card.FACEVALUE.ten, Card1.Card.SUITVALUE.clubs);
            cards[35] = new Card1.Card(Card1.Card.FACEVALUE.jack, Card1.Card.SUITVALUE.clubs);
            cards[36] = new Card1.Card(Card1.Card.FACEVALUE.queen, Card1.Card.SUITVALUE.clubs);
            cards[37] = new Card1.Card(Card1.Card.FACEVALUE.king, Card1.Card.SUITVALUE.clubs);
            cards[38] = new Card1.Card(Card1.Card.FACEVALUE.ace, Card1.Card.SUITVALUE.clubs);
            cards[39] = new Card1.Card(Card1.Card.FACEVALUE.two, Card1.Card.SUITVALUE.dimaonds);
            cards[40] = new Card1.Card(Card1.Card.FACEVALUE.three, Card1.Card.SUITVALUE.dimaonds);
            cards[41] = new Card1.Card(Card1.Card.FACEVALUE.four, Card1.Card.SUITVALUE.dimaonds);
            cards[42] = new Card1.Card(Card1.Card.FACEVALUE.five, Card1.Card.SUITVALUE.dimaonds);
            cards[43] = new Card1.Card(Card1.Card.FACEVALUE.six, Card1.Card.SUITVALUE.dimaonds);
            cards[44] = new Card1.Card(Card1.Card.FACEVALUE.seven, Card1.Card.SUITVALUE.dimaonds);
            cards[45] = new Card1.Card(Card1.Card.FACEVALUE.eight, Card1.Card.SUITVALUE.dimaonds);
            cards[46] = new Card1.Card(Card1.Card.FACEVALUE.nine, Card1.Card.SUITVALUE.dimaonds);
            cards[47] = new Card1.Card(Card1.Card.FACEVALUE.ten, Card1.Card.SUITVALUE.dimaonds);
            cards[48] = new Card1.Card(Card1.Card.FACEVALUE.jack, Card1.Card.SUITVALUE.dimaonds);
            cards[49] = new Card1.Card(Card1.Card.FACEVALUE.queen, Card1.Card.SUITVALUE.dimaonds);
            cards[50] = new Card1.Card(Card1.Card.FACEVALUE.king, Card1.Card.SUITVALUE.dimaonds);
            cards[51] = new Card1.Card(Card1.Card.FACEVALUE.ace, Card1.Card.SUITVALUE.dimaonds);

        }

        public void Shuffle()
        {
            bool badCards = true;
            Random rand = new Random();

            Card1.Card[] shuffleDeck = new Card1.Card[52];
            for (int i = 0; i < shuffleDeck.Length; i++)
            {
                badCards = false;
                int num = rand.Next(52);
                for (int c = 0; c < shuffleDeck.Length; c++)
                {
                    if (cards[num] == shuffleDeck[c])
                    {
                        badCards = true;
                        i--;
                    }
                }
                if (!badCards)
                    shuffleDeck[i] = cards[num];


            }

            cards = shuffleDeck;


        }
        public Card Dealer()
        {
            Card1.Card paper = cards[l];
            if (l < 51)
            {
                l++;
            }
            else
            {
                l = 0;
            }
            return paper;
        }
    }
}