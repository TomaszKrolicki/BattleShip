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

        public static string GetShipOrientation()
        {
            string orientation;
            do
            {
                Console.WriteLine("Enter ship orientation (R - right , D - down): ");
                orientation = Console.ReadLine().ToUpper();
                if (orientation == "R" || orientation == "D")
                {
                    return orientation;
                }
            } while (true);
        }
    }

}
