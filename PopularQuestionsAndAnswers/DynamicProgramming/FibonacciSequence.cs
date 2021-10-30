using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
    public class FibonacciSequence
    {
        public long GetFibonacciSequence(int n, Dictionary<int,long> memoization = null)
        {
            if (memoization is null)
            {
                memoization = new Dictionary<int, long>();
            }
            else if (memoization.TryGetValue(n, out long returnValue))
            {
                return returnValue;
            }
            if (n <= 2) return 1;
            else
            {
                return GetFibonacciSequence(n - 1, memoization) + GetFibonacciSequence(n - 2, memoization);
            }
        }

        public long GetFibonacciSequence(int n)
        {
            var newArray = new long[n + 1];
            newArray[1] = 1;

            for (int i = 0; i <= n; i++)
            {
                var forwardNumber = i + 1;
                var aheadOfForward = i + 2;
                newArray[forwardNumber] += newArray[i];
                if (aheadOfForward > n)
                    return newArray[n];
                newArray[aheadOfForward] +=  newArray[i];
            }
            return newArray[n];

        }


    }
}
