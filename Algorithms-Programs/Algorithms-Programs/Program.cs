using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Permutation Program, 2-Binary Search,3-Insertion Sort,4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter String to Find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
                        break;
                    case 2:
                        string txtpath = File.ReadAllText(@"E:\GitDemo\Algorithms-Problems\Algorithms-Programs\Algorithms-Programs\Utility\WordFile.txt");
                        List<string> words = new List<string>(txtpath.Split());
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;
                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);                        
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}