using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.BinarySearch
{
    public static class BinarySearch
    {
        public static int Binary_Search_RecursiveAlgorithm(int[] arrayInput, int key)
        {
            var searchReturn = Binary_Search_RecursiveAlgorithm(arrayInput, key, 0, arrayInput.Length-1);
            return searchReturn;

        }



        //Given an array of integers sorted in increasing order and a target,
        //find the index of the first element in the array that is larger or equal to the target.
        //Assume that it is guaranteed to find a satisfying number.
        public static int FirstElementNotSmallerThanTarget(int[] numbers, int target)
        {
            return FirstElementNotSmallerThanTarget(numbers, target, 0, numbers.Length - 1, -1);
        }

        public static int FirstOccurrence(int[] numbers, int target)
        {
            return FirstElementNotSmallerThanTarget(numbers, target, 0, numbers.Length - 1, -1);
        }

        public static int FindSquareRoot(int number)
        {
            return FindSquareRoot(1, number,number, -1);

        }

        private static int FindSquareRoot(int left, int right,int number,int boundaryIndex)
        {
            while(left <= right)
            {
                int mid = left + right / 2;
                int midSquare = (int) Math.Pow(mid, 2);
                if (midSquare > number)
                {
                    right = mid - 1;
                }
                else if (midSquare <= number)
                {
                    boundaryIndex = mid;
                    left = mid + 1;
                }
            }
            return boundaryIndex;
        }

        private static int Binary_Search_RecursiveAlgorithm(int[] numbers, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (numbers[mid] == target)
                    return mid;
                if (numbers[mid] < target)
                    left = mid + 1;
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        //An array of boolean values is divided into two sections: the left section consists of all false,
        //and the right section consists of all true. Find the boundary of the right section,
        //i.e.the index of the first true element.If there is no true element, return -1.

        public static int FindBoundary(bool[] values)
        {
            return FindBoundary(values, 0, values.Length - 1,-1);

        }

        private static int FindBoundary(bool[] values, int left, int right, int boundaryIndex)
        {
            while(left <= right)
            {
                int mid = (left + right) / 2;

                if (values[mid] == false)
                {
                    left = mid + 1;

                }
                else if (values[mid] == true)
                {
                    boundaryIndex = mid;
                    right = mid - 1;
                }
            }
            return boundaryIndex;
        }

        private static int FirstElementNotSmallerThanTarget(int[] numbers, int target, int left, int right, int boundaryIndex)
        {
            while(left <= right)
            {
                int mid = left + right / 2;

                if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else if (numbers[mid] >= target)
                {
                    boundaryIndex = mid;
                    right = mid - 1;
                }
            }
            return boundaryIndex;
        }

        
    }
}
