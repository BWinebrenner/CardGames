using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card1;
using Decks;
using consoleblackjack;


namespace CardMania
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Driver();
        }
        public static void Driver()
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Welcome to Card Mania!!!");
                Console.WriteLine(" ");
                Console.WriteLine("Please pick from one of the following games!!");
                Console.WriteLine("1) BlackJack");
                Console.WriteLine("2) War");
                Console.WriteLine("3) Go Fish");
                Console.WriteLine(" ");
                Console.WriteLine("EXIT");
                string gameChoice = Console.ReadLine();
                if (gameChoice == "1" || gameChoice == "BlackJack" || gameChoice == "blackjack")
                {
                    consBlackJack twentyone = new consBlackJack();
                }
                else if (gameChoice == "2" || gameChoice == "War" || gameChoice == "war")
                {
                    Console.WriteLine("coming soon");
                }
                else if (gameChoice == "3" || gameChoice == "Go Fish" || gameChoice == "go fish")
                {
                    Console.WriteLine("coming soon");
                }
                else if(gameChoice == "EXIT" || gameChoice == "Exit" || gameChoice == "exit")
                {
                    menu = false;
                }
                else
                {
                    Console.WriteLine("please enter a valid option");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
