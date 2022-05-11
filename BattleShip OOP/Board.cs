using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Board
    {

        private static int Width = 7;
        private static int Height = 7;
        public Square[,] Field;

        public Board()
        {
            Field = new Square[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Field[x, y] = new Square(x,y);
                }
            }
        }
        


    }
}
