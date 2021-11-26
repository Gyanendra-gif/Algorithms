using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Programs
{
    class BinarySearch
    {
        public static void BinarySearchWord(List<string> wordList)
        {
            int mid, start = 0; //Initialize Local Variables
            int end = wordList.Count - 1;
            bool isFound = false;
            Console.WriteLine("Enter the word to be searched in list");
            string key = Console.ReadLine();

            while (start <= end)
            {
                mid = (start + end) / 2;
                int result = key.CompareTo(wordList[mid]);
                if (result == 0)
                {
                    Console.WriteLine("Word is Present");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Word does not exist in Text File!");
            }

        }
    }
}
