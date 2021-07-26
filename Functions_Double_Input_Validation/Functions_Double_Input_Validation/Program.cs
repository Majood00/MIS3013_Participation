using System;

namespace Functions_Double_Input_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Please enter a number";
            double number = GetDoubleInputFromUser(value);
            double equation = number * 5;
            Console.WriteLine($"{number.ToString("N2")} * 5 = {equation.ToString("N2")}.");

            Console.WriteLine();
            Console.WriteLine("Do you want to input another value? yes or no?");
            string response = Console.ReadLine().ToLower();

            if (response == "no")
            {
                Console.WriteLine("Okay. Exiting the program.");
                Environment.Exit(0);
            }
            else
            {
                while (response == "yes")
                {
                    number = GetDoubleInputFromUser(value);
                    equation = number * 5;
                    Console.WriteLine($"{number.ToString("N2")} * 5 = {equation.ToString("N2")}.");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to input another value? yes or no?");
                    response = Console.ReadLine().ToLower();

                    if (response == "no")
                    {
                        Console.WriteLine("Okay. Exiting the program.");
                        Environment.Exit(0);
                    }
                }
            }
        }

        static double GetDoubleInputFromUser(string value)
        {
            Console.WriteLine(value);
            string answer = Console.ReadLine();
            double number;

            if (double.TryParse(answer, out number) == false)
            {
                while (double.TryParse(answer, out number) == false)
                {
                    Console.WriteLine($"{answer} is not a valid number. Please enter a valid number.");
                    answer = Console.ReadLine();
                }
            }

            return number;

        }
    }
}
