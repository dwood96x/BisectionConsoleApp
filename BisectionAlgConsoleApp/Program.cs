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
            BisectLogic bisect = new BisectLogic();
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bisect.BisectList(list,Console.ReadLine());
        }
    }
    class BisectLogic
    {
        public static void BisectList(int[] list,int chosenValue)
        {
            bool foundChosenValue = false;
            do
            {
                int searchInt = list.Length / 2;
                if (list[searchInt] == chosenValue)
                {
                    Console.WriteLine($"The chosen value is {chosenValue}");
                    foundChosenValue = true;
                }
                else if (list[searchInt] > chosenValue)
                {
                    Console.WriteLine($"The value is lower than {list[searchInt]}");
                }
                else
                {
                    Console.WriteLine($"The value is greater than {list[searchInt]}");
                }
            } while (foundChosenValue == false);
        }
        public static int ParsetoInt()
        {
            
            return input
        }
    }
}
