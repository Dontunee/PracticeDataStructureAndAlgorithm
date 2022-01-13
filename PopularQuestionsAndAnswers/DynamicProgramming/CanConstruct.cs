using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.DynamicProgramming
{
     public class CanConstruct
    {
        public int CanConstructSolution(string wordInput, string[] words, Dictionary<string, int> memoization)
        {
            if(memoization.TryGetValue(words.ToString(), out int returnedValue))
            {
                return returnedValue;
            }
            int numberOfWays = 0;
            if (wordInput == null) return -1;
            if (wordInput.ToCharArray().Length == 0) return 1;
            foreach (var word in words)
            {
                if (wordInput.IndexOf(word) == 0)
                {
                    var remainder = wordInput.Substring(word.Length);
                    var result = CanConstructSolution(remainder, words, memoization);
                    if (result > 0)
                    {
                        memoization.TryAdd(wordInput, result);
                        numberOfWays += result;
                    }
                }
              
            }

            memoization.TryAdd(wordInput, -1);
            return numberOfWays;
        }

        /*Given two strings s and t, return the number of distinct subsequences of s which equals t.

A string's subsequence is a new string formed from the original string by deleting some (can be none) of the characters without disturbing the remaining characters' relative positions. (i.e., "ACE" is a subsequence of "ABCDE" while "AEC" is not).

It is guaranteed the answer fits on a 32-bit signed integer.*/

        //public int Subsequent(string input, string subOf)
        //{
        //    var substring = input.Substring(1);
        //}

        //public string[][] AllConstructSolution(string wordInput, string[] words, Dictionary<string, string[][]> memoization = null)
        //{
        //    if (memoization is null)
        //    {
        //        memoization = new Dictionary<string, string[][]>();
        //    }
        //    if (memoization.TryGetValue(words.ToString(), out string[][] returnedValue))
        //    {
        //        return returnedValue;
        //    }
        //    var allways = new string[][]
        //    {
        //        new string[]{ }
        //    };
        //    if (wordInput == null) return null;
        //    if (wordInput.ToCharArray().Length == 0) return new string[][]
        //    {
        //        new string[]{ }
        //    };
        //    foreach (var word in words)
        //    {
        //        if (wordInput.IndexOf(word) == 0)
        //        {
        //            var stringArray = new List<string>();
        //            var remainder = wordInput.Substring(word.Length);
        //            var result = AllConstructSolution(remainder, words, memoization);
        //            if (result != null)
        //            {
        //                memoization.TryAdd(wordInput, result);
        //                allways[i]stringArray.Add(word);
        //            }

        //        }

        //    }

        //    memoization.TryAdd(wordInput, -1);
        //    return numberOfWays;
        //}
    }
}
