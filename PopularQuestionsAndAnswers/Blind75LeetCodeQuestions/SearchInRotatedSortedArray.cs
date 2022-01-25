using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
     public static class SearchInRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int numsLength = nums.Length;
            int leftPointer = 0;
            int rightPointer = numsLength - 1;

            if (numsLength < 1 || numsLength > 5000)
                return -1;

            if (numsLength == 1 && nums[rightPointer] == target)
                return 0;
            if (numsLength == 1 && nums[rightPointer] != target)
                return -1;
            if (target < -Math.Pow(10, 4) || target > Math.Pow(10, 4))
                return -1;


            while (leftPointer <= rightPointer)
            {

                if (nums[leftPointer] < -Math.Pow(10, 4) ||
                    nums[rightPointer] < -Math.Pow(10, 4) ||
                    nums[leftPointer] > Math.Pow(10, 4) ||
                    nums[rightPointer] > Math.Pow(10, 4))
                    return -1;
                int middlePointer = (leftPointer + rightPointer) / 2;
                if (nums[middlePointer] == target)
                {
                    return middlePointer;
                }

                if (nums[leftPointer] <= nums[middlePointer])
                {
                    if (target > nums[middlePointer] || target < nums[leftPointer])
                        leftPointer = middlePointer + 1;
                    else
                    {
                        rightPointer = middlePointer - 1;
                    }
                }
                else
                {
                    if (target < nums[middlePointer] || target > nums[rightPointer])
                        rightPointer = middlePointer - 1;
                    else
                    {
                        leftPointer = middlePointer + 1;
                    }

                }
            }

            return -1;
        }
    }
}
