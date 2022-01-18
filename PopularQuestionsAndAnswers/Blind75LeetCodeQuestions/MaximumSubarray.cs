using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class MaximumSubarray
    {

        public static int MaxSubArray(int[] nums)
        {
            var numsLength = nums.Length;
            if (numsLength < 1 || numsLength > Math.Pow(10, 5))
                return 0;

            if (numsLength == 1)
                return nums[0];

            int currentSum = 0;
            int maximumSum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -Math.Pow(10, 4) || nums[i] > Math.Pow(10, 4))
                    return 0;

                if (currentSum < 0)
                {
                    currentSum = 0;
                }
                currentSum += nums[i];
                maximumSum = Math.Max(maximumSum, currentSum);
            }
            return maximumSum;
        }
    }
}
