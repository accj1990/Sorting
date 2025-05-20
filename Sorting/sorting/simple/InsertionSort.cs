using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] Sorting(int[] vet)
        {
            stopwatch.Start();
            
            int j, x;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                assignments++;
                
                j = i - 1;
                
                while (j >= 0 && vet[j] > x)
                {
                    comparisons++;
                    vet[j + 1] = vet[j];
                    assignments++;
                    j--;
                }
                comparisons++;
                
                vet[j + 1] = x;
                assignments++;
            }
            
            stopwatch.Stop();
            return vet;
        }
    }
}
