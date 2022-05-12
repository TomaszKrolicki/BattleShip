using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Validation
    {
        public static bool PlaceShipValidation(int x, int y, Square[,] board, ShipType shipType, string orientation)
        {
            Console.WriteLine("tu sa kordy");
            Console.WriteLine(x);
            Console.WriteLine(y);

            if (x >= 7 || y >= 7)
            {
                return false;
            }
                                                    //sprawdza czy wgole kordy sa w zakresie
            if (x < 0 || y < 0)
            {
                return false;
            }

            //sprawdza czy wgole kordy sa w zakresie//sprawdza czy wgole kordy sa w zakresie
            //sprawdza czy wgole kordy sa w zakresie
            
            if (orientation == "D")
            {
                if (x - 1 + (int)shipType > 6)
                {
                    return false;
                } 
            }
                                                    //sprawdza czy statek sie miesci na bordzie w danym kierunku 
            if (orientation == "R")
            {
                if (y - 1+ (int)shipType > 6)
                {
                    return false;
                }
            }


            if (board[x, y].Symbol != '~')
            {
                return false;                       //sprawdza czy pole jest puste
            }



            if (x == 0 && y==0)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
            }

            if (x == 6 && y == 6)
            {
                if (board[x -1, y].Symbol == 'S') return false;
                if (board[x, y -1].Symbol == 'S') return false;
            }

            if (x == 6 && y == 0 && x!=6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
            }

            if (x == 0 && y == 6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x, y - 1].Symbol == 'S') return false;
            }

            if (x == 0 && y != 0 && y !=6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
                if (board[x, y - 1].Symbol == 'S') return false;
            }

            if (x == 6 && y != 0)
            {
                if (board[x - 1, y].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
                if (board[x, y - 1].Symbol == 'S') return false;
            }


            if (x != 0 && y == 0 && x!=6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x - 1, y].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
            }

            if (x != 0 && y == 6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x - 1, y].Symbol == 'S') return false;
                if (board[x, y - 1].Symbol == 'S') return false;
            }

            if (x != 0 && y != 0 && x != 6 && y != 6)
            {
                if (board[x + 1, y].Symbol == 'S') return false;
                if (board[x - 1, y].Symbol == 'S') return false;
                if (board[x, y - 1].Symbol == 'S') return false;
                if (board[x, y + 1].Symbol == 'S') return false;
            }



            return true;
        }
    }
}
