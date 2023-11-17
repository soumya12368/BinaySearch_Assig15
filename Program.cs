using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_Assig15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generating a random array
            int[] array = GenerateRandomArray(20, 1, 200);

            Console.WriteLine("Original Array:");
            DisplayArray(array);

            // Sorting the array using Bubble Sort
            BubbleSort(array);

            Console.WriteLine("\nSorted Array:");
            DisplayArray(array);

            // Checking if the array is sorted correctly
            if (IsSorted(array))
            {
                Console.WriteLine("\nThe array is sorted correctly.");
            }
            else
            {
                Console.WriteLine("\nThe array is not sorted correctly.");
            }

            // Performing Binary Search
            int searchValue = 42;
            int result = BinarySearch(array, searchValue);

            if (result != -1)
            {
                Console.WriteLine($"\n{searchValue} found at index {result}.");
            }
            else
            {
                Console.WriteLine($"\n{searchValue} not found in the array.");
            }
        }

        // Bubble Sort algorithm for sorting an array in descending order
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Method to check if an array is sorted correctly
        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Binary Search algorithm
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid; // Element found
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1; // Search in the left half
                }
                else
                {
                    left = mid + 1; // Search in the right half
                }
            }

            return -1; // Element not found
        }

        // Method to generate a random array of integers
        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

        // Method to display an array
        static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
