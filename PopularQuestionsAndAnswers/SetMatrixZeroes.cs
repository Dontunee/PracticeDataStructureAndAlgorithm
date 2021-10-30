using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            var dictionary = new List<Dict>();


            if (m < 1 || n > 200) return;

            for (int i = 0; i < m; i++ )
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] >= -Math.Pow(2,31) && matrix[i][j] <= Math.Pow(2,31))
                    {
                        if (matrix[i][j] == 0)
                        {
                            var dict = new Dict(i, j);
                            dictionary.Add(dict);
                        }
                    }
                }
            }

            foreach (var item in dictionary)
            {
                ChangeToZeros(matrix,item.Key,item.Value - 1,"left");
                ChangeToZeros(matrix,item.Key,item.Value + 1, "right");
                ChangeToZeros(matrix,item.Key - 1,item.Value, "top");
                ChangeToZeros(matrix,item.Key + 1,item.Value,"down");
            }

            
        }

        private static void ChangeToZeros(int[][] matrix, int key, int value, string position)
        {
            if (key < 0 || value < 0 || key >= matrix.Length || value >= matrix[0].Length ) return;
            if(matrix[key][value] != 0)
            {
                matrix[key][value] = 0;
            }
            if(position == "left")
            {
                ChangeToZeros(matrix, key , value - 1 ,position);
            }
            if (position == "right")
            {
                ChangeToZeros(matrix, key, value + 1, position);
            }
            if (position == "top")
            {
                ChangeToZeros(matrix, key - 1, value,position);
            }
            if (position == "down")
            {
                ChangeToZeros(matrix, key + 1, value,position);
            }
        }

        public class Dict
        {
            public int Key { get; private set; }

            public int  Value { get; private set; }


            public Dict(int key, int value)
            {
                Key = key;
                Value = value;

            }
        }
    }
}
