using System;

namespace Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a type of animal");
            string animal = Console.ReadLine().ToLower();

            string sound = Speak(animal);
            
            Console.WriteLine($"A {animal} makes a {sound} sound.");

        }

        static string Speak(string animal)
        {
            string sounds;

            if (animal == "wolf")
            {
                sounds = "Woof";
            }
            else if (animal == "cat")
            {
                sounds = "Meow";
            }
            else if (animal == "snake")
            {
                sounds = "Sssssssss";
            }
            else
            {
                sounds = "Buzzz";
            }
            
            return sounds;
        }

    }
}
