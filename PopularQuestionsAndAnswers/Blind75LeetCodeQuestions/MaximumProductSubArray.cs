using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class MaximumProductSubArray
    {
        public static int MaxProduct(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 2 * Math.Pow(10, 4))
                return -1;
            int maximumProduct = 1;
            int minimumProduct = 1;
            int result = nums[0];


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -10 || nums[i] > 10)
                    return -1;
                if (nums[i] == 0)
                {
                    maximumProduct = 1;
                    minimumProduct = 1;
                }
                {
                    int temp = maximumProduct;
                    maximumProduct = Math.Max(nums[i], Math.Max(temp * nums[i], minimumProduct * nums[i]));
                    minimumProduct = Math.Min(nums[i], Math.Min(temp * nums[i], minimumProduct * nums[i]));

                    result = Math.Max(result, maximumProduct);
                }

            }

            return result;

        }

    }
}
