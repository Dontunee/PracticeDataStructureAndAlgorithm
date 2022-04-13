using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Random.AlgoExpert
{
    public class Assessments
    {
		public static bool IsPalindrome(string str)
		{
			// Write your code here.
			bool isValid = false;
			int left = 0;
			int right = str.Length - 1;
			while (left <= right)
			{
				if (str[left] != str[right])
				{
					return isValid = false;
				}
				left++;
				right--;
			}
			return isValid = true;
		}
	}
}
