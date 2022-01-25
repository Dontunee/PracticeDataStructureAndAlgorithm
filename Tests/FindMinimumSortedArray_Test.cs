using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class FindMinimumSortedArray_Test
    {

        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 })]

        public void FindMin_ValidInput_ValidOutput(int[] nums)
        {
            var result = MinimumInRotatedSortedArray.FindMin(nums);
            Assert.Equal(1, result);

        }


    }
}
