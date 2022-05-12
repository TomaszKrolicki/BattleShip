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
                Display.DisplayBoard(this.boardToShoot);
                Tuple<int, int> cords = Input.GetPlayerCoordinates("shooting", this);
                if (Validation.IsShootValid(cords, player2))
                {
                    if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Ship)
                    {
                        // change to hit
                        Util.ChangeToHit(player2, cords, this);
                    } 
                    else if (player2.boardWithShips[cords.Item1, cords.Item2].SquereType == SquereType.Empty)
                    {
                        //change to miss
                        Util.ChangeToMiss(player2, cords, this);
                    }
                    break;
                }
                Display.ShootInTheSamePlace();
            }
            while (true);
        }

        public bool IsAlive()
        {
            if (shipList.Count == 0) return false;
            return true;
        }


        public string Name
        {
            get { return name;}
            set
            {
                name = value;
            }
        }
    }
}
