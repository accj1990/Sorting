using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static void ShellSortAlgorithm(int[] vector)
        {
            stopwatch.Start();

            int n = vector.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = vector[i];
                    assignments++;

                    int j = i;
                    while (j >= gap && vector[j - gap] > temp)
                    {
                        comparisons++;
                        vector[j] = vector[j - gap];
                        swaps++;
                        assignments++;
                        j -= gap;
                    }

                    if (j >= gap)
                        comparisons++;

                    vector[j] = temp;
                    assignments++;
                }

                gap /= 2;
            }

            stopwatch.Stop();
        }
    }
}
