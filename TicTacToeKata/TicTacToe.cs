using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeKata
{
    public class TicTacToe
    {
        public const int Width = 3;
        public const int Height = 3;
        char[,] board;
        
        public TicTacToe()
        {
            board = new char[,] {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' }
            };
        }

        public char Field(int x, int y)
        {
            
            return board[x, y];
        }

        public void PlaceXAt(int x, int y)
        {
            PlaceCharAt('X', x, y);
        }

        public void PlaceOAt(int x, int y)
        {
            PlaceCharAt('O', x, y);
        }

        public void PlaceCharAt(char val, int x, int y)
        {
            if (board[x, y] != ' ')
                return;

            board[x, y] = val;
        }

        public string Status()
        {
            //check if player X has won


            return "Game continues.";
        }

    }
}
