using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class MakingALargeIsland
    {
        public static int LargestIsland(int[][] grid)
        {
            if (grid is null || grid.Length <= 0) return 0;

            int max = 0, islandId = 2, m = grid.Length, n = grid[0].Length;


            var dictionary = new Dictionary<int, int>();

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        int size = GetIslandSize(grid, i, j, islandId);
                        max = Math.Max(max, size);
                        dictionary.Add(islandId++, size);
                    }
                }
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(grid[i][j] == 0)
                    {
                        max = ChangeMax(grid, dictionary, i, j, max);
                    }
                }
            }

            return max;

        }

        private static int ChangeMax(int[][] input, Dictionary<int, int> dictionary, int i, int j, int max)
        {
            var hashSet = new HashSet<int>();
            int highstNumber = 0;
            int leftValue = 0, rightValue = 0, topValue = 0, bottomValue = 0;
            var left = GetValue(input, i, j - 1);
            var right = GetValue(input, i, j + 1);
            var top = GetValue(input, i + 1, j);
            var bottom = GetValue(input, i - 1, j);





            if (!(left == 0 && top == 0 && right == 0 && bottom == 0))
            {

                if (left > 0)
                {
                    dictionary.TryGetValue(left, out leftValue);

                    hashSet.Add(left);
                }
                if (right > 0)
                {
                    dictionary.TryGetValue(right, out rightValue);
                    hashSet.Add(right);
                }
                if (top > 0)
                {
                    dictionary.TryGetValue(top, out topValue);
                    hashSet.Add(top);
                }

                if (bottom > 0 && hashSet.Contains(bottom) is false)
                {
                    dictionary.TryGetValue(bottom, out bottomValue);
                    hashSet.Add(bottom);
                }


                foreach (var item in hashSet)
                {
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary.TryGetValue(item, out i);
                        highstNumber += i;
                    }
                }

            }
            highstNumber += 1;
            if (highstNumber > max) max = highstNumber;


            return max;



        }

        private static int GetValue(int[][] input, int i, int j)
        {

            if (i < 0 || j < 0 || i >= input.Length || j >= input[0].Length) return 0;

            var value = input[i][j];
            return value;
        }

        private static int GetIslandSize(int[][] input, int i, int j, int islandId)
        {
             if (i < 0 || j < 0 || i >= input.Length || j >= input[0].Length || input[i][j] > 1 || input[i][j] == 0) return 0;
            input[i][j] = islandId;
            var left = GetIslandSize(input, i, j - 1, islandId);
            var right = GetIslandSize(input, i, j + 1, islandId);
            var top = GetIslandSize(input, i - 1, j, islandId);
            var down = GetIslandSize(input, i + 1, j, islandId);
            return left + right + top + down + 1;
          //  return 0;
        }
    }
}
