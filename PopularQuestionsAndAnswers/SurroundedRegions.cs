using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class SurroundedRegions
    {
        public static void Solve()
        {
            var board = new char[][]
             {
            //{
            //     new char []{ 'X', 'O', 'X', 'X' },
            //    new char [] { 'O', 'O', 'O', 'X' },
            //    new char [] { 'X', 'O', 'O', 'O' },
            //    new char [] { 'X', 'O', 'X', 'X' }
                 new char []{ 'O', 'X', 'X', 'O','X' },
                new char []{ 'X', 'O', 'O', 'X','O'  },
                new char []{ 'X', 'O', 'X', 'O','X' },
                new char [] { 'O', 'X', 'O', 'O', 'O' },
                new char [] { 'X', 'X', 'O', 'X', 'O' }
            };
            ChangeAllOsToBeChanged(board);
        }

        private static void ChangeAllOsToBeChanged(char[][] board)
        {
            var m = board.Length;
            if (m < 1 || m > 200) return;
            for(int i = 0; i < m; i++)
            {
                int n = board[i].Length;
                for(int j = 0; j < n; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        if (!CheckIfItIsInBorder(i,j,board))
                        {
                            FlipCharToX(i, j, board);
                        }
                    }
                }
            }
        }
        private static void FlipCharToX(int i, int j, char[][] board)
        {


            var isLeftOnBorder = CheckIfItIsInBorder(i, j - 1, board);
            var isRightOnBorder = CheckIfItIsInBorder(i, j + 1, board);
            var isTopOnBorder = CheckIfItIsInBorder(i - 1, j, board);
            var isBottomOnBorder = CheckIfItIsInBorder(i + 1, j, board);


            if (isLeftOnBorder)
            {
                var left = board[i][j - 1];
                if (left == 'O')
                    return;
            }
            if (isRightOnBorder)
            {
                var right = board[i][j + 1];
                if (right == 'O')
                    return;
            }
            if (isTopOnBorder)
            {
                var top = board[i - 1][j];
                if (top == 'O')
                    return;
            }
            if (isBottomOnBorder)
            {
                var bottom = board[i + 1][j];
                if (bottom == 'O')
                    return;
            }
            board[i][j] = 'X';
        }

        private static bool CheckIfItIsInBorder(int i, int j, char[][] board)
        {
            var left = IsOnBorder(i, j - 1, board);
            var right = IsOnBorder(i, j + 1, board);
            var top = IsOnBorder(i -1, j, board);
            var bottom = IsOnBorder(i + 1, j, board);
            if (left == true || right == true || top == true || bottom == true)
                return true;
            return false;
        }

        private static bool IsOnBorder(int i, int j, char[][] board)
        {
            if (i < 0 || j < 0  || i >= board.Length || j >= board[0].Length)
                return true;
            return false;
        }

    }
}
