// See https://aka.ms/new-console-template for more information
using ConnectFour;

Console.WriteLine("Hello, World!");
Board board = new Board();
board.InitBoard();
while (true)
{
    board.PrintBoard();
    board.PlaceToken();
}
//board.PrintBoard();
//board.PlaceToken();
