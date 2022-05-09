using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Display
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome in Battleship");
            Console.WriteLine();
            Console.WriteLine("1 - Start new game");
            Console.WriteLine("2 - Display high scores");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("Choose number:");
        }
    }
}
