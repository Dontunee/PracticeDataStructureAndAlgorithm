using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MaxProductSubArray
    {

        [Theory]
        [InlineData(new int[] { 2,3,-2,4})]
        public void MaxProductSubArray_ValidInput_ValidOutput(int[] nums)
        {
            var result = MaximumProductSubArray.MaxProduct(nums);
            Assert.Equal(6, result);
        }
    }
}
