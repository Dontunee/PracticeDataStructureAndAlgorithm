
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.AlgorithmMentalModels.SlidingWindow
{
    public static class TwoPointerTechnique
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int pointerOne = 0;
            int  pointerTwo = nums.Length - 1;

            Array.Sort(nums);
            while (pointerOne < pointerTwo)
            {
                int currentSum = nums[pointerOne] + nums[pointerTwo];

                if (currentSum > target)
                {
                    pointerTwo--;
                }
                else if (currentSum < target)
                {
                    pointerOne++;
                }
                else
                {
                    return new int[] { pointerOne, pointerTwo };
                }
            }
            return null;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int leftPointer = 1;

            for (int rightPointer = 1; rightPointer < nums.Length; rightPointer++)
            {
                if (nums[rightPointer] != nums[rightPointer - 1])
                {
                    nums[leftPointer] = nums[rightPointer];
                    leftPointer++;
                }
            }

            return leftPointer;
        }

        public static char[] ReverseString(char[] s)
        {
            int leftPointer = 0;
            int rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {
                char temp = s[rightPointer];
                s[rightPointer] = s[leftPointer];
                s[leftPointer] = temp;
                leftPointer++;
                rightPointer--;
            }

            return s;
        }

        public static int MaxProfit(int[] prices)
        {
            int maximumProfit = 0;
            int currentProfit = 0;
            int buyAmount = prices[0];
            int leftPointer = 0;

            for (int rightPointer = 1; rightPointer < prices.Length; rightPointer++)
            {
                int difference = prices[leftPointer] - prices[rightPointer];
                if (prices[leftPointer] > prices[rightPointer])
                {
                    buyAmount = prices[rightPointer];
                    maximumProfit = maximumProfit + currentProfit;
                    currentProfit = 0;
                }
                else if (prices[leftPointer] < prices[rightPointer])
                {
                    int gain = buyAmount - prices[rightPointer];
                    currentProfit = Math.Max(currentProfit, -(gain));
                }
                leftPointer++;
            }
            var diff = maximumProfit + currentProfit;
            maximumProfit = Math.Max(maximumProfit, diff);
            return maximumProfit;
        }

        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }

        public static void reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
                left++;
                right--;
            }
        }
    }
}
