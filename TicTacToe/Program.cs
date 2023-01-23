//IS 413 Section 4 Mission 3; Mitch Anderson, Joshua Allen, Andrew Alley, Jon Stauffer

using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] gameBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool winner = false; //checks if someone has won the game

            int count = 1; //keeps track of number of times the loop executes

            string currentPlayer; 

            string gameWinner;

            support sup = new support();

            Console.WriteLine("Welcome to Tic-Tac-Toe 2.0!");


            while (!winner && count <= gameBoard.Length)
            {
                int playerChoice;

                char token = 'X';

                Console.WriteLine();

                sup.printBoard(gameBoard);

                if (count % 2 == 0) //alternates players on even and odd turns
                {
                    currentPlayer = "Player 2";
                    token = 'O';
                }

                else
                {
                    currentPlayer = "Player 1";
                }

                Console.Write(currentPlayer + " choose a position: ");
                playerChoice = Convert.ToInt32(Console.ReadLine());

                while (gameBoard[playerChoice - 1] == 'X' || gameBoard[playerChoice - 1] == 'O') //loop catches error if position is already in use
                {
                    Console.Write("This position has already been taken, " + currentPlayer + " please choose another position: ");
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                }

                gameBoard[playerChoice - 1] = token;
                count += 1;

                if (sup.winner(gameBoard)[0] == 1) //check if a winner exists
                {
                    winner = true;

                    if (sup.winner(gameBoard)[1] == 1)
                    {
                        gameWinner = "Player 1";
                    }

                    else
                    {
                        gameWinner = "Player 2";
                    }

                    Console.WriteLine();

                    sup.printBoard(gameBoard);

                    Console.WriteLine(gameWinner + " wins!");
                }

            }

            if (!winner) //execute when count exceeds board length without a winner
            {
                Console.WriteLine();
                sup.printBoard(gameBoard);
                Console.WriteLine("It's a draw!");
            }

        }
    }
}
