using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConnectFour
{
    internal class Board
    {
        // variable to store the board
        new internal List<string>? board = new List<string>(42);

        // variable to store the current player
        new internal string currentPlayer = "X";

        // variables to store the scores
        new internal int scoresX = new();
        new internal int scoresO = new();

        // Method to initialize the backend-board
        public void InitBoard()
        {
            this.board.Clear();
            for (int i = 0; i < 42; i++)
            {
                this.board.Add(" ");
            }
        }

        // Method to print the board
        public void PrintBoard()
        {
            // Definition of static lines 
            var firstLine = new string(" A | B | C | D | E | F | G ");
            var clearLine = new string("---|---|---|---|---|---|---");

            // array of each line of the board as string
            List<string> boardLines = [];

            // Add the Scores
            boardLines.Add("Score X: " + this.scoresX + "      Score O: " + this.scoresO);

            //Add the Column Letters
            boardLines.Add(firstLine);

            // Calculate the line Strings the board
            for (int i = 5; i > -1; i--)
            {
                
                var boardRow = 5 - i;
                string displayText = " ";
                for (int j = 0; j < 7; j++)
                {
                    var element = this.board[7 * boardRow + j];
                    displayText = displayText + element;
                    if (j < 6)
                    {
                        displayText = displayText + " | ";
                    }
                }
                displayText = displayText + " ";
                boardLines.Add(clearLine);
                boardLines.Add(displayText);
            }

            // Actually print the board
            Console.Clear();
            foreach (var line in boardLines)
            {
                Console.WriteLine(line);
            }
        }


        // Method to Place a token on the board
        public void PlaceToken()
        {
            // declare the index
            int index;

            // Get the column from the user
            Console.WriteLine("Player " + this.currentPlayer + "'s turn! Where would you like to place your Chip?");
            string userInput = Console.ReadLine().ToLower();
            try
            {
                index = userInput[0] - 'a';
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Please enter a valid column! Press Enter to retry!");
                Console.ReadLine();
                return;
            }


            // Check if the column is valid
            if (index < 0 || index > 6)
            {
                Console.WriteLine("Error! Please enter a valid column! Press Enter to retry!");
                Console.ReadLine();
                return;
            }

            // Place the token
            for (int i = 0; i < 6; i++)
            {
                if (this.board[35 + index - 7 * i] == " ")
                {
                    this.board[35 + index - 7 * i] = this.currentPlayer;
                    CheckGameOver();
                    this.currentPlayer = this.currentPlayer == "X" ? "O" : "X";
                    return;
                }
            }

            // post error if the column is full and retry
            Console.WriteLine("Error! This column is full! Press Enter to retry!");
            Console.ReadLine();
            return;
        }


        // Method to check if the game is over
        public void CheckGameOver()
        {
            // Check if the board is full
            if (!this.board.Contains(" "))
            {
                Console.WriteLine("The game is a draw!");
                Console.ReadLine();
                return;
            }

            // Check if a player has won
            if (CheckWinningCondition())
            {
                PrintBoard();
                Console.WriteLine("Player " + currentPlayer + " won!");
                Console.ReadLine();
                if (this.currentPlayer == "X")
                {
                    this.scoresX++;
                }
                else
                {
                    this.scoresO++;
                }
                this.InitBoard();
            }
        }

        // Check if there is a winning constelation
        public bool CheckWinningCondition()
        {
            // Check if there are 4 in a row horizontally
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.board[7 * i + j] == this.currentPlayer &&
                        this.board[7 * i + j + 1] == this.currentPlayer &&
                        this.board[7 * i + j + 2] == this.currentPlayer &&
                        this.board[7 * i + j + 3] == this.currentPlayer)
                    {
                        return true;
                    }
                }
            }   
            

            // Check if there are 4 in a row vertically
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.board[7 * j + i] == this.currentPlayer &&
                        this.board[7 * (j + 1) + i] == this.currentPlayer &&
                        this.board[7 * (j + 2) + i] == this.currentPlayer &&
                        this.board[7 * (j + 3) + i] == this.currentPlayer)
                    {
                        return true;
                    }
                }
            }
            

            // Check if there are 4 in a row diagonally
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.board[7 * i + j] == this.currentPlayer &&
                        this.board[7 * (i + 1) + j + 1] == this.currentPlayer &&
                        this.board[7 * (i + 2) + j + 2] == this.currentPlayer &&
                        this.board[7 * (i + 3) + j + 3] == this.currentPlayer)
                    {
                        return true;
                    }
                }
            }
            

            // Check if there are 4 in a row diagonally
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this.board[7 * (i + 3) + j] == this.currentPlayer &&
                        this.board[7 * (i + 2) + j + 1] == this.currentPlayer &&
                        this.board[7 * (i + 1) + j + 2] == this.currentPlayer &&
                        this.board[7 * i + j + 3] == this.currentPlayer)
                    {
                        return true;
                    }
                }
            }
            

            // Return false if no winning condition is met
            return false;
        }
    }
}
