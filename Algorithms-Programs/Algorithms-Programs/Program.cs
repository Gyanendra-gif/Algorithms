using System;

namespace Algorithms_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Permutation Program, 2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter String to Find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
                        break;
                    case 2: flag = false;
                        break;
                }
            }
        }
    }
}