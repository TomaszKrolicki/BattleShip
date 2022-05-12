using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Player
    {
        private string name = "none";
        public Square[,] boardWithShips;
        public List<Ship> shipList;
        public Square[,] boardToShoot;


        public void AddShipToList(Ship ship)
        {
            shipList.Add(ship);
        }

        public Player(string name, Square[,] boardWithShips, Square[,] boardToShoot)
        {
            this.name = name;
            this.boardWithShips = boardWithShips;
            this.boardToShoot = boardToShoot;
            shipList = new List<Ship>();
        }

        public void Shoot(Player player2)
        {
            do
            {
                Tuple<int, int> cords = Input.GetPlayerCoordinates("shooting", this);
                if (IsShootValid(cords, player2))
                {
                    if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Ship)
                    {
                        // change to hit
                        player2.boardWithShips[cords.Item1, cords.Item2].SquereType = SquereType.Hit;
                        this.boardToShoot[cords.Item1, cords.Item2].SquereType = SquereType.Hit;
                        Util.RemoveShipSquareFromList(player2, cords);
                    } 
                    else if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Empty)
                    {
                        //change to miss
                        player2.boardWithShips[cords.Item1, cords.Item2].SquereType = SquereType.Missed;
                        this.boardToShoot[cords.Item1, cords.Item2].SquereType = SquereType.Missed;
                    } 
                    break;
                }
                Display.ShootInTheSamePlace();
            }
            while (true);
        }

        public bool IsAlive(Square[,] board)
        {
            return false;
        }


        public string Name
        {
            get { return name;}
            set
            {
                name = value;
            }
        }

        public bool IsShootValid(Tuple<int, int> cords, Player player2)
        {
            if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Hit) return false;
            if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Missed) return false;
            return true;
        }
    }
}
