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


		public static string RunLengthEncoding(string str)
		{
			// Write your code here.

			var builder = new StringBuilder();
			var currentLength = 1;

			for(var i = 1; i < str.Length; i++)
            {
				var currentCharacter = str[i];
				var previousCharacter = str[i - 1];

				if (currentCharacter != previousCharacter || currentLength == 9)
                {
					builder.Append($"{currentLength}{previousCharacter}");
					currentLength = 0;
                }

				currentLength += 1;
            }
			builder.Append($"{ currentLength}{ str[str.Length - 1]}");
			return builder.ToString();
		}

		public static bool GenerateDocument(string characters, string document)
		{
			var charDict = new Dictionary<int, int>();

            foreach (var item in characters)
            {
				var numberRep = (int)item;
				if (!charDict.ContainsKey(numberRep))
                {
					charDict.Add(numberRep, 1);
                }
                else
                {
					charDict[numberRep] += 1;
                }
            }

			var docDict = new Dictionary<int, int>();

            foreach (var item in document)
            {
				var numberRep = (int)item;

				if (!docDict.ContainsKey(numberRep))
                {
					docDict.Add(numberRep, 1);
                }
                else
                {
					docDict[numberRep] += 1;
                }
            }

            foreach (var item in docDict)
            {
				if (charDict.ContainsKey(item.Key))
                {
					if( item.Value > charDict[item.Key])
                    {
						return false;
                    }
                }
                else
                {
					return false;
                }
            }
			// Write your code here.
			return true;
		}
	}
}
