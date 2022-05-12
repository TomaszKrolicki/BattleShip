using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_OOP
{
    public class Game
    {
        public static void RunGame()
        {
            string player1Name = Input.GetPlayerName();
            Board player1BoardForShips = new Board();
            Board player1BoardForShooting = new Board();
            Player player1 = new Player(player1Name, player1BoardForShips.Field, player1BoardForShooting.Field);

            string player2Name = Input.GetPlayerName();
            Board player2BoardForShips = new Board();
            Board player2BoardForShooting = new Board();
            Player player2 = new Player(player2Name, player2BoardForShips.Field, player2BoardForShooting.Field);

            GenerateShips.ShipGenerator(player1);
            GenerateShips.ShipGenerator(player2);

            Round(player1, player2);

        }

        public static void Round(Player player1, Player player2)
        {
            while (true)
            {
                player1.Shoot(player2);
                if (!player2.IsAlive())
                {
                    //player1 wygral
                    break;
                }
                player2.Shoot(player1);
                if (!player1.IsAlive())
                {
                    //player1 wygral
                    break;
                }
            }
        }
    }
}
