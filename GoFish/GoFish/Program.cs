using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
        }

        static void ShuffleDeck()
        {
            Deck deck = new Deck();
            deck.Shuffle();

        }

        static void GivingCards()
        {
            Deck deal = new Deck();
            deal.Dealer();
            

        }

        


        
        static void MatchCards()
        {
          
            Card.FACEVALUE cardTwo = Card.FACEVALUE.two;
            int value0 = (int)cardTwo;

            Card.FACEVALUE cardThree = Card.FACEVALUE.three;
            int value1 = (int)cardThree;

            Card.FACEVALUE cardFour = Card.FACEVALUE.four;
            int value2 = (int)cardFour;

            Card.FACEVALUE cardFive = Card.FACEVALUE.five;
            int value3 = (int)cardFive;

            Card.FACEVALUE cardSix = Card.FACEVALUE.six;
            int value4 = (int)cardSix;

            Card.FACEVALUE cardSeven = Card.FACEVALUE.seven;
            int value5 = (int)cardSeven;

            Card.FACEVALUE cardEight = Card.FACEVALUE.eight;
            int value6 = (int)cardEight;

            Card.FACEVALUE cardNine = Card.FACEVALUE.nine;
            int value7 = (int)cardNine;

            Card.FACEVALUE cardTen = Card.FACEVALUE.ten;
            int value8 = (int)cardTen;

            Card.FACEVALUE cardJack = Card.FACEVALUE.jack;
            int value9 = (int)cardJack;

            Card.FACEVALUE cardQueen = Card.FACEVALUE.queen;
            int value10 = (int)cardQueen;

            Card.FACEVALUE cardKing = Card.FACEVALUE.king;
            int value11 = (int)cardKing;

            Card.FACEVALUE cardAce = Card.FACEVALUE.ace;
            int value12 = (int)cardAce;

           

        }
     
    }
}
