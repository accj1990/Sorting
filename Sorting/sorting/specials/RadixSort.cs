using System;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class RadixSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            if (vet.Length <= 1) return vet;

            int maxValue = GetMaxValue(vet);
            assignments++;

            for (int exp = 1; maxValue / exp > 0; exp *= 10)
            {
                CountingSort(vet, exp);
                assignments++; 
            }

            PrintNumbers();
            return vet;
        }

        private int GetMaxValue(int[] vet)
        {
            int maxValue = vet[0];
            assignments++;

            for (int i = 1; i < vet.Length; i++)
            {
                comparisons++;
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                    assignments++;  
                }
            }

            return maxValue;
        }

        private void CountingSort(int[] vet, int exp)
        {
            int[] count = new int[10];
            int[] ordered = new int[vet.Length];
            assignments += 10;
            assignments += vet.Length; 

            for (int i = 0; i < vet.Length; i++)
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

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                int digit = (vet[i] / exp) % 10;
                int pos = count[digit] - 1;
                ordered[pos] = vet[i];
                assignments++; 
                swaps++; 
                count[digit]--;
                assignments++;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = ordered[i];
                assignments++; 
                swaps++; 
            }
        }
    }
}