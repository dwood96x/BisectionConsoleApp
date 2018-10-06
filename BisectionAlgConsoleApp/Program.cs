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
}
