using System;

namespace unityLearningExamples
{
    class Maths
    {
        public static void Min(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(("Smaller number is: ") + b);
            }
            else if (b > a)
            {
                Console.WriteLine(("Smaller number is: ") + a);
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }

        public static void Max(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(("\nBigger number is: ") + a);
            }
            else if (b > a)
            {
                Console.WriteLine(("\nBigger number is: ") + b);
            }
            else
            {
                Console.WriteLine("\nThey are equal");
            }
        }

        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                Console.WriteLine("\nNumber is smaller than 0");
                return 0;
            }
            return number * Factorial(number - 1);
        }

        public static void InsertionSort(int[] arr, int n) // n = size of an array
        {
            int i, checker, j;
            for (i = 1; i < n; i++)
            {
                checker = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > checker)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = checker;
            }
            Console.WriteLine("\nSorted array is: ");
            int k;
            for (k = 0; k < n; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }

        static void Main(string[] args)
        {
            Min(3, 5);
            Max(55, 45);
            Console.WriteLine(("\nGiven number's factorial is: ") + Factorial(5));
            int[] arr = { 1, 5, 2, 7, 30, 25, 3, 45};
            InsertionSort(arr, 8);
        }
    }
}
