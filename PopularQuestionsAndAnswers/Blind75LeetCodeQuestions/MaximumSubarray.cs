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
            int currentSum = nums[0];
            int maximumSum = int.MinValue;

            for(int i = 1; i < nums.Length; i++) { 

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
