using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
    public class CanSum
    {
        public bool CanSumMyBruteForceSolution(long canSum,int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == canSum)
                    return true;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (CheckIfCanSumExistInSubArray(canSum, i, numbers))
                    return true;
            }
            return false;
        }

        private bool CheckIfCanSumExistInSubArray(long canSum,int m, int[] numbers)
        {
            for (int i = m + 1; i < numbers.Length; i++)
            {
                if (numbers[m] + numbers[i] == canSum)
                    return true;
            }
            return false;
        }

        public bool CanSumRecursiveSolution(int canSum, int[] numbers,
            Dictionary<int,bool> memoization = null)
        {
                if (memoization is null)
                {
                    memoization = new Dictionary<int, bool>();
                }
                if (memoization.TryGetValue(canSum, out bool returnedValue))
                {
                    return returnedValue;
                }
                if (canSum == 0) return true;
                if (canSum < 0) return false;
                foreach (var item in numbers)
                {
                    var remainder = canSum - item;
                    var response = CanSumRecursiveSolution(remainder, numbers, memoization);
                    if (response)
                        memoization.Add(canSum, response);
                    return true;
                }
                memoization.Add(canSum, false);
                return false;
      
        }


    }
}
