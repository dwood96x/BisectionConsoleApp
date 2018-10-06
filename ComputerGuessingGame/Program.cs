using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerGuessingGame comp = new ComputerGuessingGame();
            comp.GuessingGame();
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
