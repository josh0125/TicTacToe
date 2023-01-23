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
            for(int i = 0; i < board.Length; ++i)
            {
                Console.Write(board[i]);

                if (test.Contains(i))
                {
                    Console.Write('|');
                }
                
                if ((i == 2) || (i == 5))
                {
                    Console.WriteLine("-------");
                }
                
            }
        }
        //int winner(char[] board)
       
    }
}
