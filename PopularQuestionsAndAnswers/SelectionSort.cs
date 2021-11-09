using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public static class SelectionSort
    {
        public static void Sort(List<int> numbers)
        {
            Sort(numbers, numbers.Count);
        }

        public static void Sort(List<int> numbers,int cursor)
        {
            if (cursor == 1) return;
            var getLargest = GetLargestNumber(numbers,cursor, out int key);
            SwapLargestWithTheEnd(getLargest, key, numbers,cursor);
            cursor = cursor - 1;
            Sort(numbers,cursor);
        }

        private static void SwapLargestWithTheEnd(int getLargest, int key, List<int> numbers, int cursor)
        {
            var numberToSwap = numbers[cursor - 1];
            numbers[cursor - 1] = getLargest;
            numbers[key] = numberToSwap;
        }

        private static int GetLargestNumber(List<int> numbers, int cursor, out int key)
        {
            var largestNumber = numbers[0];
            key = 0;
            for(int i = 1; i < cursor; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                    key = i;
                }
            }

            return largestNumber;
        }
    }
}
