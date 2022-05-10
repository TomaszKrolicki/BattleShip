using System;



namespace BattleShip_OOP
{
    class Battleship
    {
        public static void Main(string[] args)
        {
            Square square = new Square(5,6);
            square.SquereType = SquereType.Ship;
            Console.WriteLine(square.Symbol);
            Console.WriteLine(square);
            Display.MainMenu();
            // MainManuValidSelection
            int player = Input.GetNumberFromMenu(new int[] { 1,2,3});
            Display.BoardFactoryMenu();         
            int board = Input.GetNumberFromMenu(new int[] { 1,2 });
            Board board1 = new Board();
            board1.createBoard();

            // jezeli nowa gra
            // player 1
            // wprowadz imie
            // player 2
            // wprowadz imie
            // player 1
            // wyswietla sie board do ustalenia pozycji statków dla player 1
            // player 2
            // wyswietla sie board do ustalenia pozycji statków dla player 2

            // statki do dyspozycji Carrier (1 x 1), Cruiser(1x2), Battleship(1x3), Submarine(1x4), and Destroyer(1x5).
            // input statkow na board
            // statki w lini prostej, horyzontalnie lub wertykalnie
            // statki nie moga laczyc sie ze soba
            // validacja czy sie da postawic statek, nie wychodzi poza board i czy nie laczy sie z innym 




            // rozpoczyna sie gra.
            // player 1 tura - strzelanie 
            // wyswietlamy zakryty board gracza 2
            // jezeli trafia to strzela dalej, jesli pudluje - next turn
            // funkcja sprawdzenia zwyciestwa
            // player 2 tura - strzelanie 
            // wyswietlamy zakryty board gracza 1
            // jezeli trafia to strzela dalej, jesli pudluje - next turn
            // funkcja sprawdzenia zwyciestwa

            //koniec gry w przypadku zestrzelenia wszystkich statkow przez jednego z playerow

        }
    }
}

