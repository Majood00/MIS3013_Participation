using System;

namespace Conditional_Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 3);
            Console.WriteLine(number);

            Console.WriteLine("Heads or Tails? Please select one.");
            string response = Console.ReadLine();

            string guess;

            if (number == 1)
            {
                guess = "Heads";
            }
            else
            {
                guess = "Tails";
            }

            if (response.ToUpper() == guess.ToUpper())
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
