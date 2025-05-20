using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.specials
{
    class CountingSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] CountingSortAlgorithm(int[] vet)
        {
            stopwatch.Start();

            int n = vet.Length;
            if (n == 0)
            {
                stopwatch.Stop();
                return vet;
            }

            int max = vet[0];
            int min = vet[0];
            assignments += 2;
            
            for (int i = 1; i < n; i++)
            {
                comparisons += 2;
                if (vet[i] > max)
                {
                    max = vet[i];
                    assignments++;
                }
                if (vet[i] < min)
                {
                    min = vet[i];
                    assignments++;
                }
            }

            int range = max - min + 1;
            int[] count = new int[range];
            assignments++;
            
            for (int i = 0; i < n; i++)
            {
                count[vet[i] - min]++;
                assignments++;
            }
            
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                comparisons++;
                while (count[i] > 0)
                {
                    vet[index++] = i + min;
                    assignments++;
                    count[i]--;
                    assignments++;
                }
            }

            stopwatch.Stop();
            return vet;
        }
    }
}
