using System;

namespace Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sounds = "Please enter a type of animal";
            
            string sound = Speak(sounds);
            
            Console.WriteLine($"A ... makes a {sound} sound.");

        }

        static string Speak(string sounds)
        {
            Console.WriteLine(sounds);
            string animal = Console.ReadLine().ToLower();

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
