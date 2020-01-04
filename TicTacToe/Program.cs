using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            string[,] board = new string[,]
            {
                { " ", " ", " " },
                { " ", " ", " " },
                { " ", " ", " " }
            };

            printBoard(board);

            void isGameOver()
            {

            }

            void printBoard(string[,] board)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("+---+---+---+");
                    Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" {0} ", board[i, j]);
                        Console.Write("|");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("+---+---+---+");

            }

            Console.WriteLine("Hello World!");
        }
    }
}
