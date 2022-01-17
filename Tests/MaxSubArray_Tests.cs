using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MaxSubArray_Tests
    {
        [Theory]
        [InlineData(new int[] { -2,1,-3,4,-1,2,1,-5,4})]
        public void MaxSubArray_ValidInput_ReturnsValidOutput(int[] nums)
        {
            var result = MaximumSubarray.MaxSubArray(nums);
            Assert.Equal("6", result.ToString());
        }
    }
}
