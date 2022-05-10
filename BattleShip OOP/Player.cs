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
        private char[,] board = new char[7,7];


        public Player(string name, char[,] board)
        {
            this.name = name;
            this.board = board;
        }

        public void GetShoot(int x, int y)
        {
            board[x,y] = 'X' ;
        }

        public bool IsAlive(char[,] board)
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
