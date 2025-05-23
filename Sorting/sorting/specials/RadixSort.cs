using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorting.sorting.specials
{
    class RadixSort
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int comparisons = 0;
        static int swaps = 0;
        static int assignments = 0;
        
        public static int[] RadixSortAlgorithm(int[] vet)
        {
            stopwatch.Start();

            if (vet.Length == 0)
            {
                stopwatch.Stop();
                return vet;
            }

            int max = GetMax(vet);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(vet, exp);
            }

            stopwatch.Stop();
            return vet;
        }

        private static int GetMax(int[] vet)
        {
            int max = vet[0];
            assignments++;

            for (int i = 1; i < vet.Length; i++)
            {
                comparisons++;
                if (vet[i] > max)
                {
                    max = vet[i];
                    assignments++;
                }
            }

            return max;
        }

        private static void CountingSortByDigit(int[] vet, int exp)
        {
            int n = vet.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            assignments += 2;
            
            for (int i = 0; i < n; i++)
            {
                int digit = (vet[i] / exp) % 10;
                count[digit]++;
                assignments++;
            }
            
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                assignments++;
            }
            
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (vet[i] / exp) % 10;
                output[count[digit] - 1] = vet[i];
                assignments++;
                count[digit]--;
                assignments++;
            }
            
            for (int i = 0; i < n; i++)
            {
                vet[i] = output[i];
                assignments++;
            }
        }
        
        public static void PrintStats()
        {
            Console.WriteLine("Comparisons: " + comparisons);
            Console.WriteLine("Assignments: " + assignments);
            Console.WriteLine("Swaps: " + swaps);
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed.TotalMilliseconds.ToString("F5") + " ms");
        }
        
        // public static void Main(string[] args)
        // {
        //     string filePath = "C:\\Users\\Buza\\Desktop\\AedsIISorting\\MateusBarcelos\\Sorting\\inputs\\10-aleatorios.txt";
        //     string content = File.ReadAllText(filePath);
        //     int[] vector = content
        //         .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse)
        //         .ToArray();
        //
        //     RadixSortAlgorithm(vector);
        //     PrintStats();
        // }
    }
}
