using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decks;
using Card1;

namespace consoleblackjack
{
    public class consBlackJack
    {
        private static int playerhand = 0;
        private static int AIhand = 0;
        private static Deck paper = new Deck();
        private static Card[] playhand = new Card[5];
        private static Card[] AIsHand = new Card[5];
        private static int arrayCount = 0;
        private static int aiarraycount = 0;

        public static void Main(string[] args)
        {
            WinLose();
        }
        public static void WinLose()
        {
            playerlogic();
            AIlogic();
            if (AIhand == 21 && playerhand != 21)
            {
                Console.WriteLine("Im sorry, the Dealer has 21, you lose");
            }
            else if (AIhand > 21 && playerhand < 22)
            {
                Console.WriteLine("Congrats, the Dealer busted!! you win!!");
            }
            else if (playerhand < AIhand && AIhand < 22)
            {
                Console.WriteLine("your hand: " + playerhand + ", and the Dealer has: " + AIhand + ", so you lose!!!");
            }
            else if (playerhand == 21 && AIhand != 21)
            {
                Console.WriteLine("Congrats, you have 21!!! you win!!!");
            }
            else if (playerhand > 21 && AIhand < 22)
            {
                Console.WriteLine("Im sorry you busted...you lose!!!");
            }
            else if (playerhand > AIhand && playerhand < 22)
            {
                Console.WriteLine("your hand: " + playerhand + ", and the Dealer has: " + AIhand + ", so you win!!!");
            }
            Console.WriteLine("thanks for playing!!");
        }
        public static void playerlogic()
        {
            PlaygetCard();
            PlaygetCard();
            Console.WriteLine("hand: " + playhand[0].ToString() + ", " + playhand[1].ToString());
            for (int y = 2; y < playerhand; y++)
            {
                if (playhand[y] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(", " + playhand[y].ToString());
                }
            }
            Console.WriteLine(" ");
            bool checker = true;
            while (checker)
            {
                Console.WriteLine("would you like to  hit or stay");
                string response = Console.ReadLine();
                if (response.Equals("Hit") || response.Equals("hit"))
                {
                    PlaygetCard();
                    Console.WriteLine("hand: " + playhand[0].ToString() + ", " + playhand[1].ToString());
                    for (int g = 2; g < playhand.Length; g++)
                    {
                        if (playhand[g] == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(", " + playhand[g].ToString());
                        }
                    }
                    if(playerhand > 21)
                    {
                        break;
                    }
                }
                else if (response.Equals("Stay") || response.Equals("stay"))
                {
                    checker = false;
                }
                else
                {
                    Console.WriteLine("that input is invalid");
                    Console.WriteLine(" ");
                }
            }
        }
        public static void PlaygetCard()
        {
            paper.Shuffle();
            Card play1 = paper.Dealer();
            playhand[arrayCount] = play1;
            arrayCount++;
            if (play1.getFaceValue() == Card.FACEVALUE.ace)
            {
                if ((playerhand + 11) > 21)
                {
                    playerhand += 1;
                    Console.WriteLine("you got an ace but it has to be one not to bust");
                }
                else
                {
                    playerhand += 11;
                    Console.WriteLine("you got an ace, since you wont bust, its value is 11");
                }
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.two)
            {
                playerhand += 2;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.three)
            {
                playerhand += 3;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.four)
            {
                playerhand += 4;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.five)
            {
                playerhand += 5;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.six)
            {
                playerhand += 6;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.seven)
            {
                playerhand += 7;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.eight)
            {
                playerhand += 8;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.nine)
            {
                playerhand += 9;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.ten)
            {
                playerhand += 10;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.jack)
            {
                playerhand += 10;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.queen)
            {
                playerhand += 10;
            }
            else if (play1.getFaceValue() == Card.FACEVALUE.king)
            {
                playerhand += 10;
            }
        }
        public static void AIlogic()
        {
            AIgetCard();
            AIgetCard();
            bool menu = true;
            while (menu)
            {
                if (AIhand < 21)
                {
                    Console.WriteLine("Dealers hand: " + AIsHand[0].ToString() + ", " + AIsHand[1].ToString());
                    for (int y = 2; y < AIhand; y++)
                    {
                        if (AIsHand[y] == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(", " + AIsHand[y].ToString());
                        }
                    }
                    Console.WriteLine(" ");
                    bool checker = true;
                    while (checker)
                    {
                        if (AIhand < 17)
                        {
                            AIgetCard();
                            Console.WriteLine("Dealers hand: " + AIsHand[0].ToString() + ", " + AIsHand[1].ToString());
                            for (int y = 2; y < AIhand; y++)
                            {
                                if (AIsHand[y] == null)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(", " + AIsHand[y].ToString());
                                }
                            }
                        }
                        else if (AIhand > 17)
                        {
                            checker = false;
                            menu = false;
                        }

                    }
                }
            }
        }
        public static void AIgetCard()
        {
            Card AI1 = paper.Dealer();
            AIsHand[aiarraycount] = AI1;
            aiarraycount++;
            if (AI1.getFaceValue() == Card.FACEVALUE.ace)
            {
                if ((AIhand + 11) > 21)
                {
                    AIhand += 1;
                    Console.WriteLine("the Dealer got an ace but it has to be one not to bust");
                }
                else
                {
                    AIhand += 11;
                    Console.WriteLine("the Dealer got an ace, since the Dealer wont bust, its value is 11");
                }
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.two)
            {
                AIhand += 2;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.three)
            {
                AIhand += 3;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.four)
            {
                AIhand += 4;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.five)
            {
                AIhand += 5;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.six)
            {
                AIhand += 6;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.seven)
            {
                AIhand += 7;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.eight)
            {
                AIhand += 8;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.nine)
            {
                AIhand += 9;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.ten)
            {
                AIhand += 10;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.jack)
            {
                AIhand += 10;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.queen)
            {
                AIhand += 10;
            }
            else if (AI1.getFaceValue() == Card.FACEVALUE.king)
            {
                AIhand += 10;
            }
        }
    }
}
