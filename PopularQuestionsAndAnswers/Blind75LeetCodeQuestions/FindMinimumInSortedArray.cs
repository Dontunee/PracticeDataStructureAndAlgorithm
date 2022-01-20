using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class FindMinimumInSortedArray
    {
        public static int FindMin(int[] nums)
        {
            int numsLength = nums.Length;
            int result = nums[0];
            if (numsLength < 1 || numsLength > 5000)
                return -1;
            int leftPointer = 0;
            int rightPointer = numsLength - 1;

            while(leftPointer <= rightPointer)
            {
                if (nums[leftPointer] < nums[rightPointer])
                    result =  Math.Min(result,nums[leftPointer]);
               int  middlePointer = (leftPointer + rightPointer) / 2;

                if (nums[leftPointer] < -5000 ||
                    nums[rightPointer] < -5000 ||
                    nums[leftPointer] > 5000 ||
                    nums[rightPointer] > 5000)
                    return -1;
                
                if (nums[middlePointer] >= nums[leftPointer] )
                {
                    leftPointer = middlePointer + 1;
                }
                else if(nums[middlePointer] < nums[rightPointer])
                {
                    rightPointer = middlePointer - 1;
                }
                result = Math.Min(result, nums[middlePointer]);
            }

            return result;
        }
    }
}
