using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe 2.0!");
            support sup = new support();
            char[] array = {'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' };
            sup.printBoard(array);
            Console.ReadLine();


        }
    }
}
