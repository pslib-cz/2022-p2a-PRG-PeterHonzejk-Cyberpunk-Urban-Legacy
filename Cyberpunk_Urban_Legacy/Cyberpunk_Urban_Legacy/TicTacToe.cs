using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberpunk_Urban_Legacy
{
    class TicTacToeGame
    {
        private char[] board;
        private char currentPlayer;
        private Random random;

        public TicTacToeGame()
        {
            board = new char[9];
            currentPlayer = 'X';
            random = new Random();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }

        public void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("\n {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
            Console.WriteLine("\nThe enigmatic figure unveils their true identity as Vex, a ruthless serial killer who delights in playing a deadly game of Cybergrid. The stakes are high, as losing means facing a gruesome fate, being mercilessly slashed in half. However, a glimmer of hope remains, as victory holds the power to grant us a single, elusive wish.");
            Console.WriteLine("\nYou will be playing as X. May fortune favor you in this treacherous battle.");
        }


        private char GetSymbol(char cell)
        {
            if (cell == 'X')
                Console.BackgroundColor = ConsoleColor.Magenta;
            else if (cell == 'O')
                Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Write(cell);
            Console.ResetColor();

            return cell;
        }

        public char GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool MakeMove(int position)
        {
            if (position >= 0 && position < 9 && board[position] == ' ')
            {
                board[position] = currentPlayer;
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                return true;
            }

            return false;
        }

        public bool CheckWin(char symbol)
        {
            // Check rows
            if ((board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                (board[6] == symbol && board[7] == symbol && board[8] == symbol))
                return true;

            // Check columns
            if ((board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                (board[2] == symbol && board[5] == symbol && board[8] == symbol))
                return true;

            // Check diagonals
            if ((board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                (board[2] == symbol && board[4] == symbol && board[6] == symbol))
                return true;

            return false;
        }

        public bool IsBoardFull()
        {
            foreach (char cell in board)
            {
                if (cell == ' ')
                    return false;
            }

            return true;
        }

        public int GetRandomMove()
        {
            int position;

            do
            {
                position = random.Next(0, 9);
            }
            while (board[position] != ' ');

            return position;
        }
    }
}