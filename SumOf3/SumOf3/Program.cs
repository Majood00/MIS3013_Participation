using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number. Any number is acceptable incuding decimals.");
            double number_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a new number.");
            double number_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a third number.");
            double number_3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The numbers you input are {number_1}, {number_2} and {number_3}.");

            double calculation_1 = number_1 + number_2 + number_3;
            string calculation1 = calculation_1.ToString("N3");
            Console.WriteLine(calculation1);
            const double numberValue = 7.777;
            double calculation_2 = calculation_1 * numberValue;
            string calculation2 = calculation_2.ToString("N3");
            Console.WriteLine(calculation2);
        }
    }
}
