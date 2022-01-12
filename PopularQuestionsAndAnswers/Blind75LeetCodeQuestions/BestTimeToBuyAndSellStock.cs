using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Blind75LeetCodeQuestions
{
    public static class BestTimeToBuyAndSellStock
    {

        public static int MaxProfitBruteForceSolution(int[] numbers)
        {
            if (numbers.Length < 1 || numbers.Length > Math.Pow(10, 5))
                return 0;
            int maximumProfit = 0;
            for(int i = 0; i <= numbers.Length - 2; i++)
            {
                for (int j = 1; j <= numbers.Length - 1; j++)
                {
                    if (numbers[j] < 0 || numbers[j] > Math.Pow(10, 4) || numbers[i] < 0 || numbers[i] > Math.Pow(10, 4))
                        return 0;
                    var dayProfit = numbers[j] - numbers[i];
                    if (dayProfit > 0)
                    {
                        if(dayProfit > maximumProfit)
                        {
                            maximumProfit = dayProfit;
                        }
                    }
                }
            }
            return maximumProfit;
        }

        public static int MaxProfitOptimizedSolution(int[] prices)
        {
            if (prices.Length < 1 || prices.Length > Math.Pow(10, 5))
                return 0;
            int left = 0, right = 1, max = 0;
            for(int i = 0; i < prices.Length && right < prices.Length; i++)
            {
                if (prices[i] < 0 || prices[i] > Math.Pow(10, 4))
                    return 0;
                if (prices[right] < prices[left])
                {
                    left = right;
                    right++;
                }
                else
                {
                    var difference = prices[right] - prices[left];
                    max = Math.Max(max, difference);
                    right++;
                }
            }
            return max;
        }
    }
}
