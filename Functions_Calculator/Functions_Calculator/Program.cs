using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Majood Haddad", "MIS 3013", "7/26/2021");

        }

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;

            return sum;
        }

        static void DeveloperInformation(string name, string course, string date)
        {
            Console.WriteLine($"{name} wrote this application for {course} on {date}.");
        }



    }
}
