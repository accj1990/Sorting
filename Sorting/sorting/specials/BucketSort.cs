using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.specials
{
    class BucketSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] BucketSortAlgorithm(int[] vet)
        {
            stopwatch.Start();

            if (vet.Length == 0)
            {
                stopwatch.Stop();
                return vet;
            }

            int n = vet.Length;
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
            
            int bucketCount = (int)Math.Sqrt(n);
            List<int>[] buckets = new List<int>[bucketCount];
            assignments++;

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
                assignments++;
            }
            
            for (int i = 0; i < n; i++)
            {
                int index = (int)((float)(vet[i] - min) / (max - min + 1) * bucketCount);
                buckets[index].Add(vet[i]);
                assignments++;
            }

            int idx = 0;
            foreach (var bucket in buckets)
            {
                InsertionSort(bucket);

                foreach (var item in bucket)
                {
                    vet[idx++] = item;
                    assignments++;
                }
            }

            stopwatch.Stop();
            return vet;
        }
            
        private static void InsertionSort(List<int> bucket)
        {
            for (int i = 1; i < bucket.Count; i++)
            {
                int key = bucket[i];
                int j = i - 1;
                assignments++;

                while (j >= 0)
                {
                    comparisons++;
                    if (bucket[j] > key)
                    {
                        bucket[j + 1] = bucket[j];
                        assignments++;
                        j--;
                    }
                    else break;
                }

                bucket[j + 1] = key;
                assignments++;
            }
        }
    }
}
