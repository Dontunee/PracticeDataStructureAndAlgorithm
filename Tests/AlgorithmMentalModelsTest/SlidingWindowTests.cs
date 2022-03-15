using PopularQuestionsAndAnswers.AlgorithmMentalModels.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.AlgorithmMentalModelsTest
{
    public class  SlidingWindowTests
    {

       [Fact]
        public void BruteForceAverageOfKContigousSubArray_ValidInput_ReturnsValidOutput()
        {
            //Array: [1, 3, 2, 6, -1, 4, 1, 8, 2], K=5
            var solution = SlidingWindow.SlidingWindowSolution(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);
            Assert.Equal(new double[] { 2.2, 2.8, 2.4, 3.6, 2.8},solution);
        }

        [Fact]
        public void FindMinSubArray_ReturnsValidAnswer()
        {
            var smallestSubArray = SlidingWindow.FindMinSubArray(new int[] { 2, 1, 5, 2, 3, 2 }, 7);
            Assert.Equal(2, smallestSubArray);

        }

        [Fact]
        public void LongesLongestSubstringKDistinct_ReturnsValidAnswer()
        {
            var longestSubstring = SlidingWindow.LongestSubstringKDistinct("araaci", 1);
            Assert.Equal(2, longestSubstring);
        }

        [Fact]
        public void MaxFruitCountOf2Types_ReturnsValidAnswer()
        {
            var maximumFruit = SlidingWindow.MaxFruitCountOf2Types(new char[] { 'A', 'B', 'C', 'A', 'C' });
            Assert.Equal(3, maximumFruit);
        }

        [Fact]
        public void NoRepeatSubstring_ReturnsValidAnswer()
        {
            var longestSub = SlidingWindow.NoRepeatSubstring("abbbb");
            Assert.Equal(2, longestSub);
        }

        [Fact]
        public void FindPermutation_ReturnsValidAnswer()
        {
            //Input: String="oidbcaf", Pattern="abc"
            var isPermutationExist = SlidingWindow.FindPermutation("odicf", "dc");
            Assert.False(isPermutationExist);
        }
    }
}
