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
                Tuple<int, int> cords = Input.GetPlayerCoordinates("placement");
                string orientation = Input.GetShipOrientation();
                AddShipsToList(orientation, cords, player, i);
                // dodac input do kordynatow  i pozycja statku (dol lub lewo)
            }
        }

        public static void AddShipsToList(string orientation, Tuple<int, int> cords, Player player, int number)
        {
            ShipType shipType = (ShipType)number;
            int shipLength = (int)shipType;
            int column = cords.Item1;
            int row = cords.Item2;
            for (int j = 0; j < (int)shipLength; j++)
            {
                if (orientation == "R")
                {
                    player.AddShipToList(new Ship(new Tuple<int, int>(column, row + j), shipType));
                    player.boardWithShips[column, row + j].SquereType = SquereType.Ship;
                    Display.DisplayBoard(player.boardWithShips);
                    //for (int x = 0; x < player.shipList[j].GetLength(); x++)
                    //{
                    //    player.boardWithShips[column,row]
                    //}

                } 
                else if (orientation == "D")
                {
                    player.AddShipToList(new Ship(new Tuple<int, int>(column + j, row), shipType));
                    player.boardWithShips[column + j, row].SquereType = SquereType.Ship;
                    Display.DisplayBoard(player.boardWithShips);
                }
                
            }
            
            

        }

    }
}
