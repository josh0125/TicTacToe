using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class support
    {
        public void printBoard(char[] board)
        {
            int[] test = { 0, 1, 3, 4, 6, 7 };
            for (int i = 0; i < board.Length; ++i)
            {
                Console.Write(board[i]);
                if (test.Contains(i))
                {
                    Console.Write('|');
                }
                if ((i == 2) || (i == 5))
                {
                    Console.WriteLine("");
                    Console.WriteLine("------");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public int[] winner(char[] board)
        {
            int[] decision = { 0, 0 };
            char finalWinner = ' ';
            
            if ((board[0] == board[1]) && (board[1] == board[2]))
            {
                finalWinner = board[0];
            }
            else if ((board[3] == board[4]) && (board[4] == board[5]))
            {
                finalWinner = board[3];
            }
            else if ((board[6] == board[7]) && (board[7] == board[8]))
            {
                finalWinner = board[6];
            }
            else if ((board[0] == board[3]) && (board[3] == board[6]))
            {
                finalWinner = board[0];
            }
            else if ((board[1] == board[4]) && (board[4] == board[7]))
            {
                finalWinner = board[1];
            }
            else if ((board[2] == board[5]) && (board[5] == board[8]))
            {
                finalWinner = board[2];
            }
            else if ((board[0] == board[4]) && (board[4] == board[8]))
            {
                finalWinner = board[0];
            }
            else if ((board[2] == board[4]) && (board[4] == board[6]))
            {
                finalWinner = board[2];
            }



            if (finalWinner == 'X')
            {
                decision[0] = 1;
                decision[1] = 1;
            }
            else if (finalWinner == 'O')
            {
                decision[0] = 1;
                decision[1] = 2;
            }
            return (decision);
        } 
    }
}
