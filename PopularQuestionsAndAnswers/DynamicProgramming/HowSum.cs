using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
    public class HowSum
    {
        public List<int> HowSumSolution(int targetNum,
                            int[] numbers, Dictionary<int, List<int>> memoization = null)
        {
            if (memoization is null)
            {
                memoization = new Dictionary<int, List<int>>();
            }
            if (memoization.TryGetValue(targetNum, out List<int> returnedValue))
            {
                return returnedValue;
            }
            if (targetNum == 0)
            {
                return new List<int>();
            }
            if (targetNum < 0) return null;
            foreach (var item in numbers)
            {
                var remainder = targetNum - item;
                var response = HowSumSolution(remainder, numbers, memoization);
                if (response != null)
                {
                    response.Add(item);
                    memoization.Add(targetNum, response);
                    return response;
                }
            }

            memoization.Add(targetNum, null);
            return null;
        }
    }
}
