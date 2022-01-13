using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class ContainsDuplicate
    {
        // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        public static bool ContainsDuplicateSolution(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > Math.Pow(10, 5))
                return false;
            var hashSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (item < -Math.Pow(10, 9) || item > Math.Pow(10, 9))
                    return false;
                if(hashSet.Contains(item))
                {
                    return true;
                }
                else
                {
                    hashSet.Add(item);
                }
            }
            return false;

        }

    }
}
