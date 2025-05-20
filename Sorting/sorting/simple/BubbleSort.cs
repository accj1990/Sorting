using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.simple
{
    class BubbleSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            
            int n = vet.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    comparisons++;
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                        
                        swaps++;
                        assignments += 3;
                    }
                }
            }
            
            stopwatch.Stop();
            return vet;
        }
    }
}
