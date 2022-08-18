using System;

namespace SelectionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 9;
            Console.WriteLine("Welcome to the Selection and statements exercise program. What is my favorite number?");

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Sorry, you guessed too low of a value.");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Heh, looks you guessed way too high of a value.");
            }
            else if (userGuess == 9)
            {
                Console.WriteLine("Hey! That's my favorite number!");
            }
            else
            {
                Console.WriteLine("No worries. Better luck next time.");
            }
            Console.WriteLine("Thank you for your attempt on the first portion of this exercise. Now onto the next one.");
            Console.WriteLine("");
            string subject = "Selections";
            Console.WriteLine("Welcome to the second portion of the Selection and statements exercise program. What is your favorite school subject?");
            string userSubject = Console.ReadLine();
            switch (userSubject)
            {
                case "Selections":
                    Console.WriteLine("Wonderful! What a great choice!");
                    break;
                case "Statements":
                    Console.WriteLine("Cool, that's awesome. I'm happy for you.");
                    break;
                case "Methods":
                    Console.WriteLine("Not bad. You're off to a good start.");
                    break;
                case "Operators":
                    Console.WriteLine("Alright, if you say so.");
                    break;
                case "Variables":
                    Console.WriteLine("Ho-Ho-Ho. Ok.");
                    break;
                default:
                    Console.WriteLine("Aww, well, to be perfectly honest; we're engineers of software, here. We speak code. Eh?");
                    break;
            }

        }
    }
}
