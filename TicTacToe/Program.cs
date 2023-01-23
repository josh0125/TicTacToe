using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] gameBoard = { '1','2','3','4','5','6','7','8','9' };

            bool winner = false;

            int count = 1;

            string currentPlayer = "";

            string gameWinner = "";

            //support sup = new support();

            Console.WriteLine("Welcome to Tic-Tac-Toe 2.0!");

            while (!winner && count <= gameBoard.Length)
            {
                int playerChoice = 0;

                char token = 'X';

                //sup.printBoard(gameBoard);

                if (count % 2 == 0)
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

                while (gameBoard[playerChoice - 1] == 'X' || gameBoard[playerChoice - 1] == 'O')
                {
                    Console.Write("This position has already been taken, " + currentPlayer + " please choose another position: ");
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                }

                gameBoard[playerChoice - 1] = token;
                count += 1;

                //if (sup.winner(gameBoard)[0] == 1)
                //{
                //    winner = true;

                //    if (sup.winner(gameBoard[1] == 1){
                //        gameWinner = "Player 1";
                //    }

                //    else
                //    {
                //        gameWinner = "Player 2";
                //    }

                //    Console.WriteLine(gameWinner + " wins!");
                //}

            }

            if (!winner)
            {
                Console.WriteLine("It's a draw!");
            }

        }
    }
}
