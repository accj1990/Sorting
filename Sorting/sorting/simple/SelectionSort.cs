using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            
            int n = vet.Length;
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    comparisons++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
                
                swaps++;
                assignments += 3;
            }
            
            stopwatch.Stop();
            return vet;
        }
    }
}
