using PopularQuestionsAndAnswers.Blind75LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class SearchRotatedSortedArr_Test
    {

        [Theory]
        [InlineData(new int[] { 3,1},2)]
        public void Search_ValidInput_ReturnsValidResponse(int[] nums, int target)
        {
            var result = SearchInRotatedSortedArray.Search(nums, target);
            Assert.Equal(result, -1);
        }
    }
}
