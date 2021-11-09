using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Fundamentals
{
    public static class BinarySearch
    {
        public static int Binary_Search_RecursiveAlgorithm(int[] arrayInput, int key)
        {
            int low = 0;
            int high = arrayInput.Length - 1;
            var searchReturn = Binary_Search_RecursiveAlgorithm(arrayInput, key, low, high);
            return searchReturn;

        }

        private static int Binary_Search_RecursiveAlgorithm(int[] arrayInput, int key, int low, int high)
        {
            if (high < low)
                return -1;


            int mid = (low + high) / 2;

            if (key == arrayInput[mid])
                return mid;

            if (arrayInput[mid] < key)
                low = mid + 1;
            else
            {
                high = mid - 1;
            }

            var getValue =  Binary_Search_RecursiveAlgorithm(arrayInput, key, low, high);
            return getValue;
            
        }
    }
}
