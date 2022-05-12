using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public static class Util
    {
        public static Tuple<int, int> ParseCoordinatesIntoTuple(string coordinates)
        {
            string alpha = "ABCDEFG";
            int column = alpha.IndexOf(coordinates[0]);
            int row = (int)coordinates[1] - 49;
            return new Tuple<int, int>(column, row);
        }

        public static bool CheckPlayerInput(string coordinates)
        {
            char[] alpha = "ABCDEFG".ToCharArray();
            if (coordinates.Length == 2 && alpha.Contains(coordinates[0]) && coordinates[1] >= 0 && ((int)coordinates[1] - 48) <= 7)
            {
                return true;
            }
            return false;
        }

        public static void RemoveShipSquareFromList(Player player2, Tuple<int, int> cords)
        {
            foreach (Ship ship in player2.shipList)
            {

                if (ship.GetShipCoordinates() == cords)
                {
                    player2.shipList.Remove(ship);
                }
            }
        }

        public static void ChangeToHit(Player player2, Tuple<int,int> cords, Player player1)
        {
            player2.boardWithShips[cords.Item1, cords.Item2].SquereType = SquereType.Hit;
            player1.boardToShoot[cords.Item1, cords.Item2].SquereType = SquereType.Hit;
            RemoveShipSquareFromList(player2, cords);
        }

        public static void ChangeToMiss(Player player2, Tuple<int, int> cords, Player player1)
        {
            player2.boardWithShips[cords.Item1, cords.Item2].SquereType = SquereType.Missed;
            player1.boardToShoot[cords.Item1, cords.Item2].SquereType = SquereType.Missed;
            //komentarz
            //cos
        }
    }

}
