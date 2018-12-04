using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int numberToGuess = randomNumber.Next(1, 100);
            int userGuess = 0;
            bool match = false;

            Console.WriteLine("I have in mind a number between 1 and 100. Can you guess it ? :)");

            while (!match)
            {
                Console.Write("Your guess is: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("That's not a number. Please enter a number.");
                    continue;
                }

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("The number I have in mind is higher than the number you entered. Please try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("The number I have in mind is lower than the number you entered. Please try again.");
                }
                else
                {
                    match = true;
                    Console.WriteLine("Yay, you guessed! Merry Christmas!");

                }
            }
        }

    }
}
