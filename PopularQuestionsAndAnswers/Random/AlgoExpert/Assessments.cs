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
			bool isValid = true ;
			int left = 0;
			int right = str.Length - 1;
			while (left <= right)
			{
				if (str[left] != str[right])
				{
					isValid = false;
					return isValid;
				}
				left++;
				right--;
			}
			return isValid;
		}

		public static string CaesarCypherEncryptor(string str, int key)
		{
			// Write your code here.
			//get modular number if number is above alphabets number
			key = key % 26;
			//loop through every character , get the integer representation , move by 2 and append in the result 
			//if number representation + key is above number rep of z 
			// if above 122 get modular difference plus 96
			//return the result


			var builder = new StringBuilder();

			foreach (var item in str)
			{
				int max = (int)'z';
				var numberRepresentation = (int)item;
				numberRepresentation += key;
				if (numberRepresentation > max)
				{
					numberRepresentation = 96 + (numberRepresentation % 122);
				}

				var characterRepresentation = (char)numberRepresentation;
				builder.Append(characterRepresentation);
			}
			return builder.ToString();
		}
	}
}
