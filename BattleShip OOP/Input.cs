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
            string userInput = Console.ReadLine();
            
            bool isNumber = int.TryParse(userInput, out int value);
            while (!isNumber || !valibleInts.Contains(value))
            
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Try again");
                userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput, out value);
            }
            return value;
        }

        public static Tuple<int,int> GetPlayerShootCoordinates()
        {
            Console.WriteLine("Where you want to shoot? (ex. 'A1')");
            string coordinates = Console.ReadLine();
            bool isPlayerInputCorrect = Util.CheckPlayerInput(coordinates);
            while (!isPlayerInputCorrect)
            {
                Console.WriteLine("Wrong input!!! Try again. (e.g. 'A1')");
                coordinates = Console.ReadLine();
                isPlayerInputCorrect = Util.CheckPlayerInput(coordinates);
            }

            return Util.ParseCoordinatesIntoTuple(coordinates);
        }
    }
}
