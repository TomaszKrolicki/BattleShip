using System;



namespace BattleShip_OOP
{
    class Battleship
    {
        public static void Main(string[] args)
        {
            Display.MainMenu();
            int menuNumber = Input.GetNumberFromMenu(new int[] { 1, 2 });
            if (menuNumber == 1) Game.RunGame();
            else if (menuNumber == 2) Environment.Exit(0);
        }
    }
}

