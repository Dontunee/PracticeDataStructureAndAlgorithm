using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming.Google
{
    public class PathWithMaximumGold
    {
        
        public int Solution()
        {
            int maximumGold = 0;
            var array = new int[][]
            {
                new int [] {0,6,0},
                new int [] {5,8,7},
                new int [] {0,9,0},
            };

            //answer is 24

            if (array == null || array.Length == 0 ) return maximumGold;
            int m = array.Length; int n = array[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(array[i][j] != 0 && array[i][j] != -1)
                    {
                        var visited = new Dictionary<int,bool>();
                        var getMaximum = GetMaximumGold(array, i, j,m,n, visited);
                        maximumGold = Math.Max(maximumGold, getMaximum);
                    }
                }
            }

            return maximumGold;
        }

        private int GetMaximumGold(int[][] array, int i, int j, int m, int n, Dictionary<int,bool> visited)
        {
            if (i < 0 || j < 0 || i >= m || j >= n || array[i][j] == 0 || visited.ContainsKey(m*100+n)) return 0;
            visited.Add(m * 100 + n, true);
            int left = GetMaximumGold(array, i, j - 1, m, n, visited);
            int top = GetMaximumGold(array, i - 1, j, m, n, visited);
            int bottom = GetMaximumGold(array, i + 1, j, m, n, visited);
            int right = GetMaximumGold(array, i, j + 1, m, n, visited);
            visited.Remove(m * 100 + n);
            visited.Add(m * 100 + n, false);
            var max = Math.Max(left, Math.Max(right, Math.Max(top, bottom))) + array[i][j];
            return max;
        }

     
    }
}
