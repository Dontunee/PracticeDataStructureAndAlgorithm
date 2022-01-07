using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Random
{
    public static class Problems
    {
        //Valid Parentheses
        //Given a string s containing just the characters '(", ')', (, '}', 'I' and ']', determine if the input string is valid.
        //An input string is valid if:
        //1. Open brackets must be closed by the same type of brackets.
        //2. Open brackets must be closed in the correct order.
        //Constraints:
        //1 <= s.length <= 104
        //s consists of parentheses only({[}])
        //Example 1:
        //Input: s="{}[[]]"
        //Output: valid
        //Example 2:
        //Input: S = "{[](()[])}"
        //Output: valid
        //Example 3:
        //Input: S = "(]"
        //Output: invalid

        public static string IsValidParenthesis(string input)
        {
            string output = string.Empty;
            if (input.Length < 1 || input.Length > 104)
                throw new ArgumentOutOfRangeException("input is length is less than one or greater than 104");
            var parenthesisList = ListOfParenthesis();
            var dictionary = ListOfCorrespondingBrackets();
            var openingBrackets = new Stack<char>();
            foreach (var character in input)
            {
                if(parenthesisList.Contains(character))
                {
                    if (dictionary.ContainsKey(character))
                    {
                        openingBrackets.Push(character);
                    }
                    else
                    {
                        if(openingBrackets.Any())
                        {
                            var correspondingClosing = dictionary.GetValueOrDefault(openingBrackets.Pop());
                            if(correspondingClosing != character)
                            {
                                return  "invalid";
                            }
                        }
                        else
                        {
                            return  "invalid";
                        }
                    }
                }
                else
                {
                    return "invalid";
                }
            }
            return "valid";
        }

        private static Dictionary<char,char> ListOfCorrespondingBrackets()
        {
            return new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[', ']' }
            };
        }

        private static HashSet<char> ListOfParenthesis()
        {
            var bracketList = new HashSet<char>();
            bracketList.Add('(');
            bracketList.Add(')');
            bracketList.Add('[');
            bracketList.Add(']');
            bracketList.Add('{');
            bracketList.Add('}');

            return bracketList;
        }
    }
}
