using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ProductOfArrayExceptSelf_Tests
    {
        [Theory]
        [InlineData(new int[] {1,2,3,4})]
        public void ProductExceptSelf_ValidInput_ValidOutput(int[] numbers)
        {
            var response = ProductOfArrayExceptSelf.ProductExceptSelf(numbers);
            Assert.Equal(new int[] { 24,12,8,6}, response);
        }
    }
}
