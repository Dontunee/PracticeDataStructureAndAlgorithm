using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PopularQuestionsAndAnswers
{
    public static class CheckPermutation
    {
        public static bool Solution(string inputOne, string inputTwo)
        {
            inputTwo.ToUpper();
            var trimInputOne = inputOne.Replace(" ", string.Empty);
            var trimInputTwo = inputTwo.Replace(" ", string.Empty);
            if (trimInputOne.Length != trimInputTwo.Replace(" ", string.Empty).Length) return false;
            return SortInput(trimInputOne).Equals(SortInput(trimInputTwo));
        }

        static string  SortInput(string input)
        {
            var inputAsArray = input.ToCharArray();
            Array.Sort(inputAsArray);
            return inputAsArray.ToString();
        }
    }
}
