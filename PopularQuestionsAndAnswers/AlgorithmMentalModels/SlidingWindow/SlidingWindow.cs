using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.AlgorithmMentalModels.SlidingWindow
{
    public static class SlidingWindow
    {
        public static double[] BruteForceAverageOfKContigousSubArray(int[] input, int k)
        {
            //get the length 
            //get difference subtract  by k 
            //loop from the first item to index of difference 
            //add all items from that index to the next 4 and divide by 5
            //add result to output array 
            var list = new List<double>();
            int length = input.Length;
            int difference = length - k;
            for (int i = 0; i <= (difference); i++)
            {
                int sum = input[i] + input[i + 1] + input[i + 2] + input[i + 3] + input[i + 4];
                double average = sum / (double)k;
                list.Add(average);
            }
            return list.ToArray();
        }

        public static double[] SlidingWindowSolution(int[] input,int k)
        {
            var result = new List<double>();
            int currentSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currentSum += input[i];

                if (i >= k -1)
                {
                    double average = (double)currentSum / (double)k;
                    result.Add(average);
                    currentSum -= input[i - (k - 1)];
                }
            }

            return result.ToArray();

        }

        public static int FindMinSubArray(int[] input, int s )
        {
            int arrayLength = 0;
            int currentSum = 0;
            int currentLength = 0;
            int windowsStart = 0;
            var list = new List<int>();
            for (int i = 0;i < input.Length; i++)
            {
                currentSum += input[i];
                list.Add(input[i]);
                 while(currentSum >= s)
                {
                    currentLength = list.Count;
                    arrayLength = Math.Min(currentLength,arrayLength);
                    currentSum -= list[windowsStart];
                    list.RemoveAt(windowsStart);
                }
            }
            return arrayLength;
        }


        public static int LongestSubstringKDistinct(string input, int k)
        {
            // Input: String = "araaci", K = 2
            //find the length of the longest substring in it with no more than K distinct characters.
            int longest = int.MinValue;
            var dictionary = new Dictionary<char, int>();
            int currentLength = 0;
            int windowStart = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]] += 1;
                }
                else
                {
                    dictionary.Add(input[i],1);
                }
                currentLength++;
                if (dictionary.Count > k)
                {
                    if (dictionary[input[windowStart]] == 1)
                    {
                        dictionary.Remove(input[windowStart]);
                    }
                    else
                    {
                        dictionary[input[i]]--;
                    }
                    currentLength--;
                    windowStart++;
                }

                longest = Math.Max(currentLength, longest);
            }

            return longest;
        }


        public static int MaxFruitCountOf2Types(char[] input)
        {
           // ['A', 'B', 'C', 'A', 'C']
           int maximumFruitNumber =  int.MinValue;
           int currentFruitNumber = 0;
            
           int windowStart = 0;
            var hash = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                if (hash.ContainsKey(input[windowEnd]))
                {
                    hash[input[windowEnd]]++;
                }
                else
                {
                    hash.Add(input[windowEnd], 1);
                }
                currentFruitNumber++;

                while (hash.Count > 2)
                {
                    if (hash[input[windowStart]] == 1)
                    {
                        hash.Remove(input[windowStart]);
                    }
                    else
                    {
                        hash[input[windowStart]]--;
                    }
                    currentFruitNumber--;
                    windowStart++;
                }

                maximumFruitNumber = Math.Max(currentFruitNumber, maximumFruitNumber);
            }

            return maximumFruitNumber;
        }


        public static int NoRepeatSubstring(string input)
        {
            //"aabccbb"
            //convert string to array 
            //longest substring declaration integer
            //current count declaration 
            //window start int declaration 
            //hashmap declaration 
            var inputArray = input.ToArray();
            var longest = int.MinValue;
            var currentCount = 0;
            var windowStart = 0;
            var hash = new HashSet<char>();

            for(int windowEnd = 0; windowEnd < inputArray.Length; windowEnd++)
            {
                if (!hash.Contains(input[windowEnd]))
                {
                    hash.Add(input[windowEnd]);
                    currentCount++;
                }
                else
                {
                    if (hash.Contains(input[windowEnd]))
                    {
                        hash.Remove(input[windowStart]);
                        hash.Add(input[windowEnd]);
                        windowStart++;
                    }
                }
                longest = Math.Max(currentCount, longest);
            }

            return longest;
        }

        public static bool FindPermutation(string input, string pattern)
        {
            //Input: String="oidbcaf", Pattern="abc"
            // TODO: Write your code here

            //declare output false
            //declare windowstart
            //loop through all characters in array 
            //check if it exists 
            //if it doesnt add i t
            //if it does remove from the first till it doesnt again 
            //once we have items added that equals the length of pattern 
            //check if you can get all items in pattern in the hashmap 
            // if it does return true immeidately 
            // continue 


            var output = false;
            int windowStart = 0;
            var hash = new HashSet<char>();
            for (int windowEnd = 0; windowEnd < input.Length; windowEnd++)
            {
                if (hash.Count < pattern.Length)
                {
                    hash.Add(input[windowEnd]);
                }
                else
                {
                    if (hash.SetEquals(pattern.ToHashSet()))
                    {
                        return output = true;
                    }
                    else
                    {
                        hash.Remove(input[windowStart]);
                        hash.Add(input[windowEnd]);
                        windowStart++;
                    }
                }
              

            }

            return output;
        }
    }
}
