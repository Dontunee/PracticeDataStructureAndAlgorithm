using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
    public class BestSum
    {
        public List<int> BestSumSolution(int targetNumber, int[] numbers,
                                    Dictionary<int, List<int>> memoization = null)
        {
            if (memoization is null)
            {
                memoization = new Dictionary<int, List<int>>();
            }
            if (memoization.TryGetValue(targetNumber, out List<int> returnedValue))
            {
                return returnedValue;
            }
            if (targetNumber == 0) return new List<int>();
            if (targetNumber < 0) return null;

            var shortestCombination = new List<int>();
            shortestCombination = null;
            foreach (var item in numbers)
            {
                var remainder = targetNumber - item;
                var result = BestSumSolution(remainder, numbers, memoization);
                if (result != null)
                {
                    result.Add(item);
                    if ((shortestCombination == null) || result.Count < shortestCombination.Count)
                    {
                        shortestCombination = result;
                    }
                }
            }

            memoization.Add(targetNumber, shortestCombination);
            return shortestCombination;
        }
    }
}
