using PopularQuestionsAndAnswers.DynamicProgramming;
using PopularQuestionsAndAnswers.DynamicProgramming.Google;
using PopularQuestionsAndAnswers.NonLinearDataStructures;
using Spire.Pdf;
using Spire.Pdf.General.Find;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace PopularQuestionsAndAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dateFrom = DateTime.Today.AddDays(-1);
            //var dateTo = DateTime.Today;

            // Console.WriteLine(NonRepeatedCharacter.Find("A Green Apple"));
            // Console.WriteLine(RepeatedCharacter.Find("green apple"));
            // var jaggedArray = new int[][]
            //{
            //    new int [] {1,2,3,4},
            //    new int[]  {5,0,7,8},
            //    new int[]  {0,10,11,12},
            //    new int[]  {13,14,15,0}
            //};

            //  string dateTime = "08/25/2021";
            // DateTime.TryParseExact(dateTime, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedValue);
            //var abcv = Convert.ToDateTime("2021-08-23T10:00:14.4781922");
            //MainUtil _main = new MainUtil();
            //var a = _main.DecryptData("t/MMEYmuhWjeBjBAm8fu+w==");
            //var b = _main.DecryptData("9xy7Uau/nNY/P2xIo1nKkA==");

            //var table = new HashTable();
            //table.Put(6, "A");
            //table.Put(8, "B");
            //table.Put(11, "C");
            //table.Put(6, "A+");
            //table.Remove(6);


            // var factorial = Factorial.Solve(4);

            //var newTree = new BinarySearchTree<int>();
            //newTree.Insert(20);
            //newTree.Insert(10);
            //newTree.Insert(30);
            //newTree.Insert(6);
            //newTree.Insert(14);
            //newTree.Insert(24);
            //newTree.Insert(3);
            //newTree.Insert(8);
            //newTree.Insert(26);

            //var minimumValue = newTree.MinimumValue();

            //var getFib = new FibonacciSequence();
            //Console.WriteLine(getFib.GetFibonacciSequence(6));

            //var getWays = new TwoDTravellerGrid();
            //Console.WriteLine(getWays.GetTotalNumberOfWays(2, 3));


            // Three-dimensional array.
            /*int[,,] array3D = new int[2,2,3] { 
                                            {
                                                { 1, 2, 3 }, 
                                                { 4, 5, 6 } 
                                            },
                                                { { 7, 8, 9 },
                                                { 10, 11, 12 } 
                                              }
                                            };*/

            //Console.WriteLine(canSum.CanSumRecursiveSolution(300, new int[] {7,14}));

            //var bracket = new Brackets();
            //bracket.IsBracketMatch("[[{}]()]");

            //Console.WriteLine(table.Get(6));

            //var construct = new CanConstruct();
            //Console.WriteLine(construct.CanConstructSolution("abcdef",new string[] { "ab","abc", "cd", "def", "abcd" }));
            //Console.WriteLine(construct.CanConstructSolution("purple",new string[] { "purp","p", "ur", "le", "purpl" }));

            //var jaggedArray = new int[][]
            //{
            //    new int [] {1,1,1},
            //    new int [] {1,0,1},
            //    new int [] {1,1,1},
            //};
            //SetMatrixZeroes.SetZeroes(jaggedArray);

            //var maxGold = new PathWithMaximumGold();
            //Console.WriteLine(maxGold.Solution());

            //var plusOne = new PlusOne();
            //var answer = plusOne.Solution(new int[3] { 1, 2, 3 });
            //foreach (var item in answer)
            //{
            //    Console.WriteLine(item);
            //}

            //var anagram = new ValidAnagram();
            //Console.WriteLine(anagram.isAnagram("rat", "car"));

            //var flattenArray = new FlattenAnArray();
            //var answer = flattenArray.NestedArray( new object[] { new object[] { 1, 2, new int[] { 3 } }, 4 });
            //foreach (var item in answer)
            //{
            //    Console.WriteLine(item);
            //}

            var checkPermutation = CheckPermutation.Solution("dog ", "god");
            Console.WriteLine(checkPermutation);
        }
    }
}
