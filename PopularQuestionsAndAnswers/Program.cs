using PopularQuestionsAndAnswers.AlgorithmMentalModels.SlidingWindow;
using PopularQuestionsAndAnswers.DynamicProgramming;
using PopularQuestionsAndAnswers.DynamicProgramming.Google;
using PopularQuestionsAndAnswers.Fundamentals;
using PopularQuestionsAndAnswers.NonLinearDataStructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace PopularQuestionsAndAnswers
{
    static class Program
    {
        static void Main(string[] args)
        {
            BackSpaceCompare("a#c", "b");
        }

        static bool BackSpaceCompare(string s , string t)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();

            foreach (var item in s)
            {
                if (item != '#')
                {
                    stackS.Push(item);
                }
                else if (stackS.Count > 0)
                {
                    stackS.Pop();
                }
            }

            foreach (var item in t)
            {
                if (item != '#')
                {
                    stackT.Push(item);
                }
                else if (stackT.Count > 0)
                {
                    stackT.Pop();
                }
            }

            var  stackSString = StackToString(stackS);
            var stackTString = StackToString(stackT);

            
            
            
            return stackSString.Equals(stackTString);
        }


        static string StackToString (Stack<char> s)
        {
            string res = "";
            foreach (var item in s)
            {
                res += item;
            }

            return res;

        }

        static List<int> FindMegaPrimeCollection(UInt32 input)
        {
            var response = new List<int>();
            var cache = new HashSet<int>();

            if (input < 2) return response;
            for (int i = 2; i <= input; i++)
            {
                if (IsPrime(i,cache) && IsMegaPrime(i,cache))
                {
                    if (IsUint32(i.ToString()))
                    {
                        response.Add(i);
                    }
                }
            }
            return response;
        }

        private static bool IsMegaPrime(int number, HashSet<int> cache)
        {
            if (!IsPrime(number,cache))
                return false;

            while (number != 0)
            {
                int digit = number % 10;
                if (!IsPrime(digit,cache))
                    return false;

                number /= 10;
            }

            return true;
        }

        private static bool IsPrime(int number, HashSet<int> cache)
        {
            if (cache.Contains(number))
                return true;
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            // You can do less work by observing that at this point, all primes 
            // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
            // The other possible remainders have been taken care of.
            int i = 6; // start from 6, since others below have been handled.
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            cache.Add(number);
            return true;
        }

        public static bool IsUint32(string input)
        {
            uint result;
            return uint.TryParse(input, out result);
        }

    }
}
