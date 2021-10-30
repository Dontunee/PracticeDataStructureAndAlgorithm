using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public class GetTwoSum
    {

        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2 || target > Math.Pow(10,9) || target < -Math.Pow(10,9)) return null;
            var result = new Result();
            int m = nums.Length;
            for (int i = 0; i < m; i++)
            {
                if (nums[i] < -(Math.Pow(10,9)) || nums[i] > Math.Pow(10, 9)) return null;
                result  = GetAdditionFromNumber(nums, i, m, target);
                if(result.result)
                {
                    return result.array;
                }
            }
            return null;
        }

        private Result GetAdditionFromNumber(int[] arrayNumbers, int i, int m, int target)
        {
            var newAnswer = new int[2];
            int number = i;
            for (int j = ++number; j < m; j++)
            {
                if (arrayNumbers[i] + arrayNumbers[j] == target)
                {
                    newAnswer[0] = i;
                    newAnswer[1] = j;
                    return new Result()
                    {
                        result = true,
                        array = newAnswer
                    };
                }
            }
            return new Result() { result = false };
        }

        public class Result
        {
            public bool result { get; set; }

            public int[] array { get; set; }
        }
    }
}
