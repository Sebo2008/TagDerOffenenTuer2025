using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    partial class Utility
    {
        new public bool endGame = false;
        new public List<string>? board;
        new public string? player;
        new public bool gameWon;
        internal void Init()
        {
            this.board = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            this.gameWon = false;
            this.player = "X";
        }
        internal void UpdateBoard() 
        {
            Console.Clear();
            var line1 = " A | " + this.board[0] + " | " + this.board[1] + " | " + this.board[2];
            var line2 = " B | " + this.board[3] + " | " + this.board[4] + " | " + this.board[5];
            var line3 = " C | " + this.board[6] + " | " + this.board[7] + " | " + this.board[8];
            line1 = line1.Replace(@"(?<! ) {2}(?! )", " ");
            line2 = line2.Replace(@"(?<! ) {2}(?! )", " ");
            line3 = line3.Replace(@"(?<! ) {2}(?! )", " ");
            Console.WriteLine();
            Console.WriteLine("   | 1 | 2 | 3");
            Console.WriteLine("---|---|---|---");
            Console.WriteLine(line1);
            Console.WriteLine("---|---|---|---");
            Console.WriteLine(line2);
            Console.WriteLine("---|---|---|---");
            Console.WriteLine(line3);
            Console.WriteLine();
            CheckWin();
            CheckStalemate();
        }
        void CheckWin()
        {
            if (this.board[0] == this.board[1] && this.board[1] == this.board[2] && this.board[0] != " ")
            {
                Console.WriteLine("Player " + this.board[0] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[3] == this.board[4] && this.board[4] == this.board[5] && this.board[3] != " ")
            {
                Console.WriteLine("Player " + this.board[3] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[6] == this.board[7] && this.board[7] == this.board[8] && this.board[6] != " ")
            {
                Console.WriteLine("Player " + this.board[6] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[0] == this.board[3] && this.board[3] == this.board[6] && this.board[0] != " ")
            {
                Console.WriteLine("Player " + this.board[0] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[1] == this.board[4] && this.board[4] == this.board[7] && this.board[1] != " ")
            {
                Console.WriteLine("Player " + this.board[1] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[2] == this.board[5] && this.board[5] == this.board[8] && this.board[2] != " ")
            {
                Console.WriteLine("Player " + this.board[2] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[0] == this.board[4] && this.board[4] == this.board[8] && this.board[0] != " ")
            {
                Console.WriteLine("Player " + this.board[0] + " wins!");
                this.gameWon = true;
            }
            else if (this.board[2] == this.board[4] && this.board[4] == this.board[6] && this.board[2] != " ")
            {
                Console.WriteLine("Player " + this.board[2] + " wins!");
                this.gameWon = true;
            }
        }
        internal void CheckStalemate()
        {
            if (this.board.All(x => x != " "))
            {
                Console.WriteLine("Stalemate!");
                this.gameWon = true;
            }
        }
        internal void MakeMove()
        {
            Console.WriteLine("Which Field do you want to occupy?");
            string input = Console.ReadLine().ToUpper();
            if (input == "A1")
            {
                if (board[0] == " ") 
                {
                    board[0] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "A2")
            {
                if (board[1] == " ")
                {
                    board[1] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "A3")
            {
                if (board[2] == " ")
                {
                    board[2] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "B1")
            {
                if (board[3] == " ")
                {
                    board[3] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "B2")
            {
                if (board[4] == " ")
                {
                    board[4] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "B3")
            {
                if (board[5] == " ")
                {
                    board[5] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "C1")
            {
                if (board[6] == " ")
                {
                    board[6] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "C2")
            {
                if (board[7] == " ")
                {
                    board[7] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();
                }
            }
            else if (input == "C3")
            {
                if (board[8] == " ")
                {
                    board[8] = this.player;
                    UpdateBoard();
                }
                else
                {
                    Console.WriteLine("Square Occupied! Try another one");
                    MakeMove();

                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                MakeMove();
            }
            if (this.player == "X")
            {
                this.player = "O";
            }
            else
            {
                this.player = "X";
            }
        }
    }
}
