using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Random
{
    public static class Problems
    {
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

        public static List<string> Permutations(string input)
        {
            var resuslt = new List<string>();


            if (input.Length == 1)
            {
                resuslt.Add(input);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    foreach (var p in Permutations(EverythingElse(input,i)))
                    {
                        resuslt.Add(input[i] + p);
                    }
                }
            }
            return resuslt;
        }

        private static string EverythingElse(string input, int indexToIgnore)
        {
            var result = new StringBuilder();

            for (int j = 0; j < input.Length; j++)
            {
                if (indexToIgnore != j)
                    result.Append(input[j]);

            }
            return result.ToString();
        }

    }

    public class BinaryTree
    {
        public int value;

        public BinaryTree left { get; set; }

        public BinaryTree right { get; set; }

        bool BreadthFirstSearch(BinaryTree node, int searchFor)
        {
            var queue = new Queue<BinaryTree>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == null) continue;

                queue.Enqueue(current.left);
                queue.Enqueue(current.right);

                if (current.value == searchFor)
                    return true;
            }

            return false;
        }

        bool DepthFirstSearch(BinaryTree node, int searchFor)
        {
            if (node == null)
                return false;

            if (node.value == searchFor)
                return true;

            return DepthFirstSearch(node.left, searchFor) || DepthFirstSearch(node.right, searchFor);
        }

        bool DepthFirstSearchLargeTree(BinaryTree node, int searchFor)
        {
            if (node == null)
                return false;

            var stack = new Stack<BinaryTree>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current.value == searchFor)
                    return true;

                if (current.left != null)
                    stack.Push(current.left);

                if (current.right != null)
                    stack.Push(current.right);
            }

            return false;
        }


    }
}
