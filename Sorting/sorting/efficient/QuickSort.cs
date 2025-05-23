using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;

        public static int[] QuickSortAlgorithim(int[] vector, int start, int finish)
        {
            stopwatch.Start();

            if (start < finish)
            {
                int pivot = Partition(vector, start, finish);
                QuickSortAlgorithim(vector, start, pivot - 1);
                QuickSortAlgorithim(vector, pivot + 1, finish);
            }

            stopwatch.Stop();
            return vector;
        }

        private static int Partition(int[] vector, int start, int finish)
        {
            Random rand = new Random();
            int pivotIndex = rand.Next(start, finish + 1);
            Swap(vector, pivotIndex, finish);

            int pivot = vector[finish];
            assignments++;
            int i = start - 1;

            for (int j = start; j < finish; j++)
            {
                comparisons++;
                if (vector[j] <= pivot)
                {
                    i++;
                    Swap(vector, i, j);
                }
            }

            Swap(vector, i + 1, finish);
            return i + 1;
        }

        private static void Swap(int[] vector, int a, int b)
        {
            int temp = vector[a];
            vector[a] = vector[b];
            vector[b] = temp;

            swaps++;
            assignments += 3;
        }
    }
}
