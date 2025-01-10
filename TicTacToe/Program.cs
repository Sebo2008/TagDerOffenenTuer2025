// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("Hello, World!");
Utility utility = new Utility();
while (utility.endGame == false)
{
    utility.Init();
    utility.UpdateBoard();
    do
    {
        utility.MakeMove();
    } while (utility.gameWon == false);
    Console.WriteLine("Do you want to play again? Yes/No (Y/N)");
    var response = Console.ReadLine();
    if (response == "N" || response == "n")
    {
        utility.endGame = true;
    }
}

