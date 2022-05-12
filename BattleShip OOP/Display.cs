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
            Console.Write($"  A  B  C  D  E   \n");
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Console.Write($"{Field[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void CommentForShooting()
        {
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
        
        public static void CommentForShipPlacement(Player player)
        {
            Console.WriteLine($"Now {player.Name} is choosing.");
            Console.WriteLine("Where you want to place your ship??");
        }

        public static void AskForPlayerName()
        {
            Console.WriteLine("Write your name: ");
        }




    }
}
