using System;

namespace Conditional_Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 3);
            const int HEADS = 1;
            const int TAILS = 2;

            Console.WriteLine("Heads or Tails? Please select one.");
            string response = Console.ReadLine();
            int guess = -1;
            

            if (response == "Heads")
            {
                guess = HEADS;
            }
            else if (response == "Tails")
            {
                guess = TAILS;
            }
            else
            {
                Console.WriteLine("Invalid input. Bye.");
                Environment.Exit(-1);
            }

            if (number == HEADS)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
                
            if (number == guess)
            {
                Console.WriteLine("Your guess was correct.");
            }
            else
            {
                Console.WriteLine("Your guess was wrong!");
            }

            const string name = "Majood Haddad";
            Console.WriteLine(name);
        }
    }
}
