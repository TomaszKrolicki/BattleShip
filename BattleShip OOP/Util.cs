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
    }

}
