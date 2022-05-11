using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Game
    {
        public static void ShipGenerator(Player player) 
        {
            for (int i =1;i<6;i++)
            {
                string orientation = Input.GetShipOrientation();
                Tuple<int, int> cords = Input.GetPlayerShootCoordinates();
                ShipType shipType = (ShipType) i; 
                player.AddShipToList( new Ship(cords,shipType));
                 // dodac input do kordynatow  i pozycja statku (dol lub lewo)
            }
        }

    }
}
