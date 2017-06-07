using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCGOOP
{


    public enum Suit
    {
        Diamonds, Spades, Clubs, Hearts
    }
    public enum FaceValue
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
    public class Card
    {
        private readonly Suit suit;
        private readonly FaceValue faceVal;
        public FaceValue FaceVal { get { return faceVal; } }
        public Card(Suit suit, FaceValue faceVal)
        {
            this.suit = suit;
            this.faceVal = faceVal;
        }
        public override string ToString()
        {
            return "The " + faceVal.ToString() + " of " + suit.ToString();
        }
    }
    public class Deck
    {
        private string sDeck;
        protected List<Card> cards = new List<Card>();
        private Random random;
        public Deck()
        {
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue f in Enum.GetValues(typeof(FaceValue)))
                {
                    cards.Add(new Card(s, f));
                }
            }
            random = new Random();
        }
        public void Shuffle(int ShuffleAmount)
        {

            for (int n = 0; n != ShuffleAmount; n++)
            {
                for (int i = 0; i != cards.Count; i++)
                {
                    int index1 = i;
                    int index2 = random.Next(cards.Count);
                    SwapCard(index1, index2);
                }
            }
        }

        public Card Draw()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        private void SwapCard(int index1, int index2)
        {
            Card card = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = card;
        }
        public override string ToString()
        {
            foreach (Card c in cards)
            {
                sDeck += string.Format("{0}\n", c);
            }
            return sDeck;
        }
    }

    public class Player
    {
        private string sDeck;
        private List<Card> cards = new List<Card>();

        public int CardCount { get { return cards.Count; } }


        public void AddCard(Card c)
        {
            cards.Add(c);
        }
        public Card RemCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public override string ToString()
        {
            foreach (Card c in cards)
            {
                sDeck += string.Format("{0}\n", c);
            }
            return sDeck;
        }
    }
    public class Deal
    {
        private Deck deck = new Deck();

        public void DealCards(Player p1, Player p2)
        {
            deck.Shuffle(50);

            for (int i = 0; i != 26; i++)
            {
                p1.AddCard(deck.Draw());
                p2.AddCard(deck.Draw());
            }
        }
    }
    public class War
    {

        private Player player1 = new Player();
        private Player player2 = new Player();
        private Deal dealCards = new Deal();
        private string sStatus = "";
        private Random r = new Random();
        private int rn;

        public War()
        {
            dealCards.DealCards(player1, player2);
        }

        public void PlayGame()

        {

            while (true)
            {
                Battle(player1, player2);
                Console.ReadLine();
                if (sStatus == "!!! War !!!")
                {
                    sStatus = WarBattle(player1, player2);


                }
                if (player1.CardCount == 0 || player2.CardCount == 52)
                {
                    Console.WriteLine("Player 2 Wins");
                    Console.WriteLine("player two Cards: " + player2.CardCount);
                    Console.WriteLine("player one Cards: " + player1.CardCount);
                    break;
                }
                if (player1.CardCount == 52 || player2.CardCount == 0)
                {
                    Console.WriteLine("Player 1 Wins");
                    Console.WriteLine("player one Cards: " + player1.CardCount);
                    Console.WriteLine("player two Cards: " + player2.CardCount);
                    break;
                }
            }
        }


        private string Battle(Player p1, Player p2)
        {
            Card p1Card = p1.RemCard();
            Card p2Card = p2.RemCard();
            Console.WriteLine(string.Format("\nPlayer 1 Draws : {0}", p1Card));
            Console.WriteLine(string.Format("Player 2 Draws : {0}\n", p2Card));
            Console.WriteLine();
            if (p1Card.FaceVal > p2Card.FaceVal)
            {
                rn = r.Next(1, 2);
                if (rn == 1)
                {
                    p1.AddCard(p1Card);
                    p1.AddCard(p2Card);
                    Console.WriteLine("Player one wins this battle!");
                    Console.WriteLine("player one Cards: " + player1.CardCount);
                    Console.WriteLine("player two Cards: " + player2.CardCount);
                }
                if (rn == 2)
                {
                    p2.AddCard(p2Card);
                    p2.AddCard(p1Card);
                    Console.WriteLine("Player one wins this battle!");
                    Console.WriteLine("player one Cards: " + player1.CardCount);
                    Console.WriteLine("player two Cards: " + player2.CardCount);


                }

                return "Player 1 has won!";
            }
            else if (p2Card.FaceVal > p1Card.FaceVal)
            {
                rn = r.Next(1, 2);
                if (rn == 1)
                {
                    p1.AddCard(p1Card);
                    p1.AddCard(p2Card);
                    Console.WriteLine("Player two wins this battle!");
                    Console.WriteLine("player two Cards: " + player2.CardCount);
                    Console.WriteLine("player one Cards: " + player1.CardCount);


                }
                if (rn == 2)
                {
                    p2.AddCard(p2Card);
                    p2.AddCard(p1Card);
                    Console.WriteLine("Player two wins this battle!");
                    Console.WriteLine("player two Cards: " + player2.CardCount);
                    Console.WriteLine("player one Cards: " + player1.CardCount);


                }

                return "Player 2 has won!";
            }
            else if (p1Card.FaceVal == p2Card.FaceVal)
            {
                return "!!! War !!!";

            }
            else
            {
                return "";
            }
        }
        private string WarBattle(Player p1, Player p2)
        {
            Card p1Burn1 = p1.RemCard(); // Burn
            Card p1Burn2 = p1.RemCard(); // Burn
            Card p2Burn1 = p2.RemCard(); // Burn
            Card p2Burn2 = p2.RemCard(); // Burn
                                         // Draw 
            Card p1Card = p1.RemCard();
            Card p2Card = p2.RemCard();
            if (p1Card.FaceVal > p2Card.FaceVal)
            {


                p1.AddCard(p1Card);
                p1.AddCard(p1Burn1);
                p1.AddCard(p1Burn2);
                p1.AddCard(p2Burn1);
                p1.AddCard(p2Burn2);
                p1.AddCard(p2Card);
                Console.WriteLine("player two Cards: " + player2.CardCount);
                Console.WriteLine("player one Cards: " + player1.CardCount);

                return "Player 1 has won!";
            }
            else if (p2Card.FaceVal > p1Card.FaceVal)
            {

                p2.AddCard(p1Card);
                p2.AddCard(p1Burn1);
                p2.AddCard(p1Burn2);
                p2.AddCard(p2Burn1);
                p2.AddCard(p2Burn2);
                p2.AddCard(p2Card);
                Console.WriteLine("player two Cards: " + player2.CardCount);
                Console.WriteLine("player one Cards: " + player1.CardCount);

                return "Player 2 has won!";
            }
            else if (p1Card.FaceVal == p2Card.FaceVal)
            {
                return "!!! War !!!";
                Console.WriteLine("player two Cards: " + player2.CardCount);
                Console.WriteLine("player one Cards: " + player1.CardCount);
            }
            else
            {
                return "";
            }
        }
    }

}


