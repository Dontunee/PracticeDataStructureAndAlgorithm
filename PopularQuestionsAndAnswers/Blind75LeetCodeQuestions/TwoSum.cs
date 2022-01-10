using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class TwoSum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.
        public static int[] TwoSumBruteForceSolution(int[] nums, int target)
        {
            int numsLength = nums.Length;
            if (numsLength < 1)
                throw new ArgumentOutOfRangeException("input array must have numbers");

            for(int i = 0; i < numsLength; i++)
            {
                for(int j = 1; j < numsLength - 2; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }


        public static int[] TwoSumDictionarySolution(int[] nums, int target)
        {
            if (nums.Length < 2 || nums.Length >= 104)
                if (target <= -Math.Pow(10,9) ||target >= Math.Pow(10,9))
                    throw new ArgumentOutOfRangeException("input numbers must be greater than 0");

           
            var dictionary = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= -Math.Pow(10,9) || nums[i] >= Math.Pow(10,9))
                    throw new ArgumentOutOfRangeException("input number must be greater than 0");

                var remainderTarget = target - nums[i];
                if(dictionary.ContainsKey(nums[i]))
                {
                    return new int[] { dictionary.GetValueOrDefault(nums[i]), i };
                }
                dictionary.TryAdd(remainderTarget, i);
            }

            return new int[0] { };
        }


    }
}
