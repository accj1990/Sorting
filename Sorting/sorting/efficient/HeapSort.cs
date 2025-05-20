using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static void Sort(int[] vector)
        {
            stopwatch.Start();

            int n = vector.Length;
            
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(vector, n, i);
            
            for (int i = n - 1; i > 0; i--)
            {
                Swap(vector, 0, i);
                Heapify(vector, i, 0);
            }

            stopwatch.Stop();
        }

        private static void Heapify(int[] vector, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1; 
            int right = 2 * i + 2;

            if (left < n)
            {
                comparisons++;
                if (vector[left] > vector[largest])
                    largest = left;
            }

            if (right < n)
            {
                comparisons++;
                if (vector[right] > vector[largest])
                    largest = right;
            }
            
            if (largest != i)
            {
                Swap(vector, i, largest);
                Heapify(vector, n, largest);
            }
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
