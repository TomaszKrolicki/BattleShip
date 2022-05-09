using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Input
    {
        
        public static int GetNumberFromMenu()
        {
            string userInput = Console.ReadLine();
            int[] valibleInts = { 1, 2, 3 };
            bool isNumber = int.TryParse(userInput, out int value);
            //Console.WriteLine(!isNumber);
            //Console.WriteLine(!valibleInts.Contains(value));
            while (!isNumber || !valibleInts.Contains(value))
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Try again");
                userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput, out value);
            }
            return value;
        }

        //public static int GetNumberFromMenu()
        //{
        //    string userInput = Console.ReadLine();
        //    int[] valibleInts = { 1, 2, 3 };
        //    bool isNumber = int.TryParse(userInput, out int value);
        //    //Console.WriteLine(!isNumber);
        //    //Console.WriteLine(!valibleInts.Contains(value));
        //    while (!isNumber || !valibleInts.Contains(value))
        //    {
        //        Console.WriteLine("Wrong input!");
        //        Console.WriteLine("Try again");
        //        userInput = Console.ReadLine();
        //        isNumber = int.TryParse(userInput, out value);
        //    }
        //    return value;
        //}
    }
}
