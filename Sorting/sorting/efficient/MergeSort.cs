using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        public static void MergeSortAlgorithm(int[] vector, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortAlgorithm(vector, left, mid);
                MergeSortAlgorithm(vector, mid + 1, right);
                Merge(vector, left, mid, right);
            }
        }

        private static void Merge(int[] vector, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            
            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = vector[left + i];
                assignments++;
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = vector[mid + 1 + j];
                assignments++;
            }

            int leftIndex = 0, rightIndex = 0;
            int k = left;
            
            while (leftIndex < n1 && rightIndex < n2)
            {
                comparisons++;
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    vector[k] = leftArray[leftIndex];
                    assignments++;
                    leftIndex++;
                }
                else
                {
                    vector[k] = rightArray[rightIndex];
                    assignments++;
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                vector[k] = leftArray[leftIndex];
                assignments++;
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                vector[k] = rightArray[rightIndex];
                assignments++;
                rightIndex++;
                k++;
            }
        }

        public static void Sort(int[] vector)
        {
            stopwatch.Start();
            MergeSortAlgorithm(vector, 0, vector.Length - 1);
            stopwatch.Stop();
        }
    }
}
