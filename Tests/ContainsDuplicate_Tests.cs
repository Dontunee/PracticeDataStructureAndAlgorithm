using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ContainsDuplicate_Tests
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1})]
        public void ContainsDuplicateSolution_ValidInput_ValidSolution(int[] numbers)
        {
            var response = ContainsDuplicate.ContainsDuplicateSolution(numbers);
            Assert.True(response == true);
        }
    }
}
