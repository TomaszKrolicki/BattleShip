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
            Console.WriteLine("2 - Exit");
            Console.WriteLine("Choose number:");
        }

        public static void BoardFactoryMenu()
        {
            Console.WriteLine("Welcome in Board Factory");
            Console.WriteLine();
            Console.WriteLine("1 - Random Placement");
            Console.WriteLine("2 - Manual Placement");
            Console.WriteLine("Choose your option:");

        }

        public static void DisplayBoard(Square[,] Field)
        {
            char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            Console.Write($"  1 2 3 4 5 6 7   \n");
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                Console.Write($"{alpha[i]} ");
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Console.Write($"{Field[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void CommentForShooting(Player player)
        {
            Console.WriteLine($"Now {player.Name} is shooting.");
            Console.WriteLine("Where you want to shoot? (ex. 'A1')");
        }
        
        public static void CommentForWrongInput()
        {
            Console.WriteLine("Wrong input!!!");
        }
        
        public static void CommentForShipOrientation()
        {
            Console.WriteLine("Enter ship orientation (R - right , D - down): ");
        }

        public static void CordsError()
        {
            Console.WriteLine("Ship can't be placed here! ");
        }

        public static void CommentForShipPlacement(Player player)
        {
            Console.WriteLine($"Now {player.Name} is choosing.");
            Console.WriteLine("Where you want to place your ship??");
        }

        public static void AskForPlayerName(string player)
        {
            if (player == "player1") Console.WriteLine("Write name for first player: ");
            else Console.WriteLine("Write name for second player: ");

        }
        

        public static void ShootInTheSamePlace()
        {
            Console.WriteLine("You shot this place!! Choose different one.");
            Console.WriteLine("Press any key to shoot again.");
            Console.ReadKey();
        }

        public static void PlayerWon(Player player)
        {
            Console.WriteLine($"Congratulation!!! {player.Name} has won!!!");
            Console.WriteLine("Enter any key to exit.");
            Console.ReadKey();
        }

        public static void ConsoleClear()
        {
            Console.Clear();
        }

        public static void ItIsHit()
        {
            Console.WriteLine("Good job!!! That's a hit!!!");
            Console.WriteLine("Press any key for next player to shoot");
            Console.ReadKey();
        }
        
        public static void ItIsMiss()
        {
            Console.WriteLine("Maybe next time :(");
            Console.WriteLine("Press any key for next player to shoot");
            Console.ReadKey();
        }
    }
}
