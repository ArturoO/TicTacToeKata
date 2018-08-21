using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeKata
{
    public class TicTacToe
    {
        public const int WIDTH = 3;
        public const int HEIGHT = 3;
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

        /// <summary>
        /// Returns:
        /// 0 - if game continues
        /// 1 - if player X won
        /// 2 - if player O won
        /// 3 - if game ended in a draw
        /// </summary>
        /// <returns></returns>
        public int StatusCode()
        {
            if (CheckPlayerXWon())
                return 1;

            if (CheckPlayerOWon())
                return 2;

            if(CheckDraw())
                return 3;

            //game continues
            return 0;
        }

        bool CheckDraw()
        {
            for (var i = 0; i < WIDTH; i++)
            {
                for (var j = 0; j < HEIGHT; j++)
                {
                    if (Field(i, j) == ' ')
                        return false;
                }
            }
            return true;
        }

        bool CheckPlayerXWon()
        {
            return  CheckRows('X') || 
                    CheckCols('X') || 
                    CheckDiagonals('X');
        }

        bool CheckPlayerOWon()
        {
            return  CheckRows('O') ||
                    CheckCols('O') ||
                    CheckDiagonals('O');
        }

        bool CheckDiagonals(char sign)
        {
            if (Field(0, 0) == sign &&
                Field(1, 1) == sign &&
                Field(2, 2) == sign)
                return true;

            if (Field(2, 0) == sign &&
                Field(1, 1) == sign &&
                Field(0, 2) == sign)
                return true;

            return false;
        }

        bool CheckCols(char sign)
        {
            for (var i = 0; i < WIDTH; i++)
            {
                if (Field(i, 0) == sign &&
                    Field(i, 1) == sign &&
                    Field(i, 2) == sign)
                    return true;
            }
            return false;
        }

        bool CheckRows(char sign)
        {
            for (var i = 0; i < HEIGHT; i++)
            {
                if (Field(0, i) == sign &&
                    Field(1, i) == sign &&
                    Field(2, i) == sign)
                    return true;
            }
            return false;
        }

    }
}
