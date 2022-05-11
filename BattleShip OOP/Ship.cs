﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Ship
    {
        private Tuple<int, int> shipCoordinates;
        private List<Square> shipList;
        private readonly ShipType _shipType;


        public Ship(Tuple<int, int> coordinates, ShipType shipType)
        {
            shipCoordinates = coordinates;
            shipList = new List<Square>();
            _shipType = shipType;
        }

        

        public void AddShip(Square square)
        {
            shipList.Add(square);
        }

        public int GetLength()
        {
            return (int)_shipType;
        }
    }

    public enum ShipType
    {
        Carrier = 1,
        Cruiser,
        Battleship,
        Submarine,
        Destroyer
    }

    
}
