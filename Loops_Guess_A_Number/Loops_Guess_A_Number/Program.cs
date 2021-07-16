using System;

namespace Loops_Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a lower-bound number.");
            string response = Console.ReadLine();
            
            int lower = Convert.ToInt32(response);

            Console.WriteLine("Please enter an upper-bound number.");
            response = Console.ReadLine();
            int upper = Convert.ToInt32(response);

            Random rand = new Random();
            int number = rand.Next(lower, upper + 1);

            int guessedNumber;

            do
            {
                Console.WriteLine("A random number is being generated. \nPlease guess the number.");
                string answer = Console.ReadLine();
                bool isValidNumber = int.TryParse(answer, out guessedNumber);

                if (isValidNumber == false)
                {
                    Console.WriteLine($"{answer} was not a valid integer. Please input a number.");
                }
                else if (guessedNumber < number)
                {
                    Console.WriteLine("You guessed too low.");
                }
                else if (guessedNumber > number)
                {
                    Console.WriteLine("You guessed too high.");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The correct number is {number}.");
                }
            } while (guessedNumber != number);

            Console.WriteLine("Exiting the appliation.");
            Environment.Exit(0);
            
        }
    }
}
