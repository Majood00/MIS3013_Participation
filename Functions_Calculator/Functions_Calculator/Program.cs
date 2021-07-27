using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Majood Haddad", "MIS 3013", "7/26/2021");

            string answer;
            double value;

            do
            {
                Console.WriteLine("What is the first value you want to use in the calculation?");
                double val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the second value you want to use in the calculation?");
                double val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What type of calculation do you want to perform? Addition? Subtraction? Multiplication? Division?");
                string typeOfCalculation = Console.ReadLine().ToLower();

                if (typeOfCalculation == "addition")
                {
                    value = Add(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "subtraction")
                {
                    value = Subtract(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "multiplication")
                {
                    value = Multiply(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "division")
                {
                    value = Divide(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }

                Console.WriteLine("Would you like to perform a new calcultion? yes or no?");
                answer = Console.ReadLine().ToLower();

            } while (answer == "yes");

            Console.WriteLine("Would you like to use the result of the previous calculation as the first value in a new calculation? yes or no?");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                double val1 = value;

                Console.WriteLine("What is the second value you want to use in the calculation?");
                double val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What type of calculation do you want to perform? Addition? Subtraction? Multiplication? Division?");
                string typeOfCalculation = Console.ReadLine().ToLower();

                if (typeOfCalculation == "addition")
                {
                    value = Add(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "subtraction")
                {
                    value = Subtract(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "multiplicaation")
                {
                    value = Multiply(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }
                else if (typeOfCalculation == "division")
                {
                    value = Divide(val1, val2);
                    Console.WriteLine($"The answer to your calculation problem is {value.ToString("N2")}");
                }

            }
            else if (answer == "no")
            {
                Console.WriteLine("Would you wish to stop? yes or no?");
                answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Thank you for using our service.");
                    Environment.Exit(0);
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
