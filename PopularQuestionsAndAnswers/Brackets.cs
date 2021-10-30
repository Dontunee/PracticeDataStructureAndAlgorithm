using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public class Brackets
    {
        public bool IsBracketMatch(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var dictOfBrackets = new Dictionary<char,char>();
            dictOfBrackets.Add(']','[');
            dictOfBrackets.Add('}','{');
            dictOfBrackets.Add(')', '(');

            var arrayOfString = input.ToCharArray();
            var stackOfBrackets = new Stack<char>();
            foreach (var item in arrayOfString)
            {
                if (dictOfBrackets.ContainsValue(item))
                {
                    stackOfBrackets.Push(item);
                }
                else
                {
                    if (stackOfBrackets.Count <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        var popItem = stackOfBrackets.Pop();
                        var openingBracket = dictOfBrackets.GetValueOrDefault(item);
                        if (popItem != openingBracket)
                            return false;
                    }
                }
            }
            return true;


        }

    }
}
