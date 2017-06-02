using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card1;

namespace Deck
{

        public class Deck
        {
            private Card[] cards;

            public Deck()
            {
                cards = new Card[52];

                cards[0] = new Card(Card.FACEVALUE.two, Card.SUITVALUE.spades);
                cards[1] = new Card(Card.FACEVALUE.three, Card.SUITVALUE.spades);
                cards[2] = new Card(Card.FACEVALUE.four, Card.SUITVALUE.spades);
                cards[3] = new Card(Card.FACEVALUE.five, Card.SUITVALUE.spades);
                cards[4] = new Card(Card.FACEVALUE.six, Card.SUITVALUE.spades);
                cards[5] = new Card(Card.FACEVALUE.seven, Card.SUITVALUE.spades);
                cards[6] = new Card(Card.FACEVALUE.eight, Card.SUITVALUE.spades);
                cards[7] = new Card(Card.FACEVALUE.nine, Card.SUITVALUE.spades);
                cards[8] = new Card(Card.FACEVALUE.ten, Card.SUITVALUE.spades);
                cards[9] = new Card(Card.FACEVALUE.jack, Card.SUITVALUE.spades);
                cards[10] = new Card(Card.FACEVALUE.queen, Card.SUITVALUE.spades);
                cards[11] = new Card(Card.FACEVALUE.king, Card.SUITVALUE.spades);
                cards[12] = new Card(Card.FACEVALUE.ace, Card.SUITVALUE.spades);
                cards[13] = new Card(Card.FACEVALUE.two, Card.SUITVALUE.hearts);
                cards[14] = new Card(Card.FACEVALUE.three, Card.SUITVALUE.hearts);
                cards[15] = new Card(Card.FACEVALUE.four, Card.SUITVALUE.hearts);
                cards[16] = new Card(Card.FACEVALUE.five, Card.SUITVALUE.hearts);
                cards[17] = new Card(Card.FACEVALUE.six, Card.SUITVALUE.hearts);
                cards[18] = new Card(Card.FACEVALUE.seven, Card.SUITVALUE.hearts);
                cards[19] = new Card(Card.FACEVALUE.eight, Card.SUITVALUE.hearts);
                cards[20] = new Card(Card.FACEVALUE.nine, Card.SUITVALUE.hearts);
                cards[21] = new Card(Card.FACEVALUE.ten, Card.SUITVALUE.hearts);
                cards[22] = new Card(Card.FACEVALUE.jack, Card.SUITVALUE.hearts);
                cards[23] = new Card(Card.FACEVALUE.queen, Card.SUITVALUE.hearts);
                cards[24] = new Card(Card.FACEVALUE.king, Card.SUITVALUE.hearts);
                cards[25] = new Card(Card.FACEVALUE.ace, Card.SUITVALUE.hearts);
                cards[26] = new Card(Card.FACEVALUE.two, Card.SUITVALUE.clubs);
                cards[27] = new Card(Card.FACEVALUE.three, Card.SUITVALUE.clubs);
                cards[28] = new Card(Card.FACEVALUE.four, Card.SUITVALUE.clubs);
                cards[29] = new Card(Card.FACEVALUE.five, Card.SUITVALUE.clubs);
                cards[30] = new Card(Card.FACEVALUE.six, Card.SUITVALUE.clubs);
                cards[31] = new Card(Card.FACEVALUE.seven, Card.SUITVALUE.clubs);
                cards[32] = new Card(Card.FACEVALUE.eight, Card.SUITVALUE.clubs);
                cards[33] = new Card(Card.FACEVALUE.nine, Card.SUITVALUE.clubs);
                cards[34] = new Card(Card.FACEVALUE.ten, Card.SUITVALUE.clubs);
                cards[35] = new Card(Card.FACEVALUE.jack, Card.SUITVALUE.clubs);
                cards[36] = new Card(Card.FACEVALUE.queen, Card.SUITVALUE.clubs);
                cards[37] = new Card(Card.FACEVALUE.king, Card.SUITVALUE.clubs);
                cards[38] = new Card(Card.FACEVALUE.ace, Card.SUITVALUE.clubs);
                cards[39] = new Card(Card.FACEVALUE.two, Card.SUITVALUE.dimaonds);
                cards[40] = new Card(Card.FACEVALUE.three, Card.SUITVALUE.dimaonds);
                cards[41] = new Card(Card.FACEVALUE.four, Card.SUITVALUE.dimaonds);
                cards[42] = new Card(Card.FACEVALUE.five, Card.SUITVALUE.dimaonds);
                cards[43] = new Card(Card.FACEVALUE.six, Card.SUITVALUE.dimaonds);
                cards[44] = new Card(Card.FACEVALUE.seven, Card.SUITVALUE.dimaonds);
                cards[45] = new Card(Card.FACEVALUE.eight, Card.SUITVALUE.dimaonds);
                cards[46] = new Card(Card.FACEVALUE.nine, Card.SUITVALUE.dimaonds);
                cards[47] = new Card(Card.FACEVALUE.ten, Card.SUITVALUE.dimaonds);
                cards[48] = new Card(Card.FACEVALUE.jack, Card.SUITVALUE.dimaonds);
                cards[49] = new Card(Card.FACEVALUE.queen, Card.SUITVALUE.dimaonds);
                cards[50] = new Card(Card.FACEVALUE.king, Card.SUITVALUE.dimaonds);
                cards[51] = new Card(Card.FACEVALUE.ace, Card.SUITVALUE.dimaonds);

            }

            public void Shuffle()
            {
                bool badCards = true;
                Random rand = new Random();

                Card[] shuffleDeck = new Card[52];
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

                foreach (Card card in cards)
                {
                    Console.WriteLine(card);
                }

            }
        }
    }
