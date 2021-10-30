using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
    public class TwoDTravellerGrid
    {
        public long GetTotalNumberOfWays(int m, int n, Dictionary<object,long> memoization = null )
        {
            var anonymous = new
            {
                a = m,
                b = n
            };
            if (memoization is null)
            {
                memoization = new Dictionary<object, long>();
            }
            if (memoization.TryGetValue(anonymous, out long returnedValue))
            {
                return returnedValue;
            }
          
            if (m == 0 || n == 0) return 0;
            if (m == 1 && n == 1) return 1;

            var number = GetTotalNumberOfWays(m - 1, n, memoization) 
                + GetTotalNumberOfWays(m, n - 1, memoization);
            memoization.Add(anonymous, number);
            return number;
        }

        public long GetTotalNumberOfWays(int m , int n)
        {
            var newArray = new long[m + 1, n + 1];
            newArray[1, 1] = 1;
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if(j + 1 <= n)
                        newArray[i, j + 1] += newArray[i, j];
                    if (i+1 <= m ) 
                        newArray[i + 1, j] += newArray[i, j];
                }
            }

            return newArray[m, n];
        }
    }
}
