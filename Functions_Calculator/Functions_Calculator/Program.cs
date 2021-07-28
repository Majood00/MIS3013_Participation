using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Majood Haddad", "MIS 3013", "7/27/2021");

            double value = 0;
            double val1;
            double val2;

            while (true)
            {
                Console.WriteLine("Would you like to: \n1) perform a calculation \n2) use a previous calculation in a new calculation \n3) exit the program");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                bool isFirstValue = true;

                if (choice == 1 && isFirstValue)
                {
                    Console.WriteLine("What is the first value you want to use in the calculation?");
                    val1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What is the second value you want to use in the calculation?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What type of calculation do you want to perform? Addition? Subtraction? Multiplication? Division?");
                    string typeOfCalculation = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (typeOfCalculation == "addition")
                    {
                        value = Add(val1, val2);
                        Console.Write("The answer to your calculation problem is ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "subtraction")
                    {
                        value = Subtract(val1, val2);
                        Console.Write("The answer to your calculation problem is ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "multiplication")
                    {
                        value = Multiply(val1, val2);
                        Console.Write("The answer to your calculation problem is ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "division")
                    {
                        value = Divide(val1, val2);
                        Console.Write("The answer to your calculation problem is ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{value.ToString("N2")}");
                    }
                    Console.WriteLine();
                    isFirstValue = false;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (choice == 2)
                {
                    val1 = value;

                    Console.WriteLine("What is the second value you want to use in the calculation?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What type of calculation do you want to perform? Addition? Subtraction? Multiplication? Division?");
                    string typeOfCalculation = Console.ReadLine().ToLower();

                    if (typeOfCalculation == "addition")
                    {
                        value = Add(val1, val2);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "subtraction")
                    {
                        value = Subtract(val1, val2);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "multiplication")
                    {
                        value = Multiply(val1, val2);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                    }
                    else if (typeOfCalculation == "division")
                    {
                        value = Divide(val1, val2);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you for using our service. Have a great day!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    Console.WriteLine();
                }

            }

        }

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;

            return sum;
        }

        static double Subtract(double val1, double val2)
        {
            double subtract = val1 - val2;

            return subtract;
        }

        static double Multiply(double val1, double val2)
        {
            double multiply = val1 * val2;

            return multiply;
        }

        static double Divide(double val1, double val2)
        {
            double divide = val1 / val2;

            return divide;
        }

        static void DeveloperInformation(string name, string course, string date)
        {
            Console.WriteLine($"{name} wrote this application for {course} on {date}.");
        }

    }
}
