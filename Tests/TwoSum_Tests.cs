using PopularQuestionsAndAnswers.AlgorithmMentalModels.SlidingWindow;
using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class TwoSum_Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 },9)]
        public void BruteForceSolution_ValidArguments_ReturnsOutput(int[] numbers,int target)
        {
            var response = TwoSum.TwoSumBruteForceSolution(numbers, target);
            Assert.Equal(0, response[0]);
            Assert.Equal(1, response[1]);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        public void TwoSumDictionarySolution_ValidArguments_ReturnsOutput(int[] numbers, int target)
        {
            var response = TwoSum.TwoSumOptimizedSolution(numbers, target);
            Assert.Equal(0, response[0]);
            Assert.Equal(1, response[1]);
        }


        [Theory]
        [InlineData(new int[] { 3,2,4}, 6)]
        public void TwoSumTwoPointer_ValidArguments_ReturnsOutput(int[] numbers, int target)
        {
            var response = TwoPointerTechnique.TwoSum(numbers, target);
            Assert.Equal(1, response[0]);
            Assert.Equal(2, response[1]);
        }

    }
}
