using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanGuessingGame human = new HumanGuessingGame();
            human.GuessingGame();
        }
    }
    class HumanGuessingGame
    {
        public void GuessingGame()
        {
            Console.WriteLine("\nGuess a number between 1-1000");
            Random ran = new Random();
            int compNumber = ran.Next(1, 1000);
            bool gameOver = false;
            int tries = 0;
            do
            {
                int userInput = ParseToInt();
                tries++;
                if (userInput == compNumber)
                {
                    Console.WriteLine("You chose the correct number!");
                    gameOver = true;
                }
                else if (userInput > compNumber)
                {
                    Console.WriteLine("Too high, try again!");
                }
                else
                {
                    Console.WriteLine("Too low, try again!");
                }

            } while (gameOver == false);
            Console.WriteLine($"It took you {tries} tries to guess the correct number.");
        }
        public static int ParseToInt()
        {
            int userInput = 0;
            Console.WriteLine("Enter your guess");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter your guess");
            }
            return userInput;
        }
    }
}
