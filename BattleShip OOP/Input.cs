using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Input
    {
        
        public static int GetNumberFromMenu(int[] valibleInts)
        {
            string userInput = "";
            bool isNumber = false;
            int value = 0;

            do
            {
                userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput, out value);
                if (isNumber && valibleInts.Contains(value))
                {
                    break;
                }
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Try again");

            }
            while (true);
                return value;
        }

    }
}
