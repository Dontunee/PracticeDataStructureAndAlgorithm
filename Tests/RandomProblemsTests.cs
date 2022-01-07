using PopularQuestionsAndAnswers.Random;
using System;
using Xunit;

namespace Tests
{
    public class RandomProblemsTests
    {
       [Theory]
        [InlineData("{}[[]]")]
        [InlineData("{[](()[])}")]
        [InlineData("{()}")]
        public void IsValidParenthesis_WithValidInput_ReturnsValid(string input)
        {
            var isValid = Problems.IsValidParenthesis(input);

            Assert.Equal("valid", isValid);
        }

        [Theory]
        [InlineData("(]")]
        [InlineData("([))]")]
        [InlineData("[(])")]
        public void IsValidParenthesis_WithInvalidInput_ReturnsInvalid(string input)
        {
            var isValid = Problems.IsValidParenthesis(input);

            Assert.Equal("invalid", isValid);
        }
    }
}
