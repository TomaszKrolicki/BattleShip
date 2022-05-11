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
        private List<Ship> shipList;
        public Square[,] boardForShooting;


        public void AddShipToList(Ship ship)
        {
            shipList.Add(ship);
        }

        public Player(string name, Square[,] board)
        {
            this.name = name;
            this.boardWithShips = board;
        }

        //public void GetShoot(int x, int y)
        //{
        //    board[x,y] = 'X' ;
        //}

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
    }
}
