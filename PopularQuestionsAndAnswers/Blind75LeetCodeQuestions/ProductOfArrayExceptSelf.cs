using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length < 2 || nums.Length > Math.Pow(10, 5))
                return null;
            var response = new int[nums.Length];
            var totalLeft = new int[nums.Length];
            var totalRight = new int[nums.Length];

            totalLeft[0] = 1;
            totalRight[totalRight.Length -1] = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < -30 || nums[i] > 30)
                    return null;
                totalLeft[i] = nums[i - 1] * totalLeft[i - 1];
            }

            for(int i = nums.Length - 2; i>=0 ; i--)
            {
                totalRight[i] = nums[i + 1] * totalRight[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                response[i] = totalLeft[i] * totalRight[i];
            }

            return response;
        }
    }
}
