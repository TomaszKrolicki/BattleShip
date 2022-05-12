﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Validation
    {
        public bool PlaceShipValidation(int x, int y, Square[,] board, ShipType shipType, string orientation)
        {
            if (x >= 7 || y >= 7)
            {
                return false;
            }
                                                    //sprawdza czy wgole kordy sa w zakresie
            if (x < 0 || y < 0)
            {
                return false;
            }


            if (orientation == "D")
            {
                if (x + (int)shipType > 6)
                {
                    return false;
                } 
            }
                                                    //sprawdza czy statek sie miesci na bordzie w danym kierunku 
            if (orientation == "R")
            {
                if (y + (int)shipType > 6)
                {
                    return false;
                }
            }


            if (board[x, y].Symbol != '~')
            {
                return false;                       //sprawdza czy pole jest puste
            }



            if (board[x + 1, y].Symbol == 'S' || board[x - 1, y].Symbol == 'S' || board[x, y + 1].Symbol == 'S' ||
                board[x, y - 1].Symbol == 'S')
            {
                return false;                                                                                      // sprawdza czy nie ma statku obok
            }

            return true;
        }
    }
}
