using System;



namespace BattleShip_OOP
{
    class Battleship
    {
        public static void Main(string[] args)
        {
            Display.MainMenu();
            int player = Input.GetNumberFromMenu();
            Player newPlayer = new Player("bob", new char[2, 2]);
            Console.WriteLine(newPlayer.ame);
        }
    }
}

