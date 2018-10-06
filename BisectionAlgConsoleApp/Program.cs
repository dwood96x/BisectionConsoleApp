using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BisectAlg bisect = new BisectAlg();
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bisect.BisectList(list,bisect.ParseToInt());
            HumanGuessingGame human = new HumanGuessingGame();
            human.GuessingGame();
            ComputerGuessingGame comp = new ComputerGuessingGame();
            comp.GuessingGame();
        }
    }
    class BisectAlg
    {
        public void BisectList(int[] list,int chosenValue)
        {
            List<int> RealList = new List<int>();
            RealList.AddRange(list);
            bool foundChosenValue = false;
            do
            {
                int searchInt = (RealList.Count / 2);
                if (RealList.Count > 1)

                {
                    searchInt -= 1;
                }
                Console.WriteLine($"Checking number {RealList[searchInt]}");
                if (RealList[searchInt] == chosenValue)
                {
                    Console.WriteLine($"The chosen value is {chosenValue}");
                    foundChosenValue = true;
                }
                else if (RealList[searchInt] > chosenValue)
                {
                    Console.WriteLine($"The value is lower than {RealList[searchInt]}");
                    RealList.RemoveAll(i => i >= RealList[searchInt]);
                }
                else
                {
                    Console.WriteLine($"The value is greater than {RealList[searchInt]}");
                    RealList.RemoveAll(i => i <= RealList[searchInt]);
                }
            } while (foundChosenValue == false);
        }
        public int ParseToInt()
        {
            int userInput = 0;
            Console.WriteLine("Enter the winning number between 1 and 10.");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter the winning number between 1 and 10.");
            }
            return userInput;
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
    class ComputerGuessingGame
    {
        public void GuessingGame()
        {
            Console.WriteLine("\nEnter a number between 1-100 that the computer needs to guess.");
            int chosenNumber = ParseToInt();
            List<int> RealList = new List<int>();
            RealList.AddRange(Enumerable.Range(1, 100));
            bool foundChosenValue = false;
            do
            {
                int searchInt = (RealList.Count / 2);
                if (RealList.Count > 1)

                {
                    searchInt -= 1;
                }
                Console.WriteLine($"Is it number {RealList[searchInt]}?");
                Console.WriteLine("Enter in Yes, High, or Low.");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "yes")
                {
                    Console.WriteLine("A victory for robot kind.");
                    foundChosenValue = true;
                }
                else if (userInput.ToLower() == "high")
                {
                    Console.WriteLine("Removing high numbers from search list.");
                    RealList.RemoveAll(i => i >= RealList[searchInt]);
                }
                else if (userInput.ToLower() == "low")
                {
                    Console.WriteLine("Removing low numbers from search list.");
                    RealList.RemoveAll(i => i <= RealList[searchInt]);
                }
            } while (foundChosenValue == false);
        }
        public static int ParseToInt()
        {
            int userInput = 0;
            Console.WriteLine("Enter the number between 1 and 100");
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter the number betweeen 1 and 100");
            }
            return userInput;
        }
    }
}
