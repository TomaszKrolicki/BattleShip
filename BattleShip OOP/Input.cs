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

        public static Tuple<int,int> GetPlayerCoordinates(string mode, Player player)
        {
            if (mode == "shooting")
            {
                Display.CommentForShooting(player);
            }
            else
            {
                Display.CommentForShipPlacement(player);
            }
            string coordinates = Console.ReadLine().ToUpper();
            bool isPlayerInputCorrect = Util.CheckPlayerInput(coordinates);
            while (!isPlayerInputCorrect)
            {
                Display.CommentForWrongInput();
                coordinates = Console.ReadLine().ToUpper();
                isPlayerInputCorrect = Util.CheckPlayerInput(coordinates);
            }

            return Util.ParseCoordinatesIntoTuple(coordinates);
        }

        public static string GetShipOrientation()
        {
            string orientation;
            do
            {
                Display.CommentForShipOrientation();
                orientation = Console.ReadLine().ToUpper();
                if (orientation == "R" || orientation == "D")
                {
                    return orientation;
                }
            } while (true);
        }

        public static string GetPlayerName()
        {
            Display.AskForPlayerName();
            string playerName = Console.ReadLine();
            return playerName;
        }
    }

}
