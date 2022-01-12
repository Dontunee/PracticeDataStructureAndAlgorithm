using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class BestTimeToBuySellStock_Tests
    {

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 })]
        public void BruteForceSolution_WithValidInput_ReturnsValidOutput(int[] numbers)
        {
            var maximumProfit = BestTimeToBuyAndSellStock.MaxProfitBruteForceSolution(numbers);
            Assert.Equal(5, maximumProfit);
        }

        [Theory]
        [InlineData(new int[] { 1,2})]
        public void OptimizedSolution_WithValidInput_ReturnsValidOutput(int[] numbers)
        {
            var maximumProfit = BestTimeToBuyAndSellStock.MaxProfitOptimizedSolution(numbers);
            Assert.Equal(1, maximumProfit);
        }
    }
}
