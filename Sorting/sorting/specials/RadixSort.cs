using System;
using System.Diagnostics;

namespace Sorting.sorting.specials
{
    class RadixSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            comparisons = 0;
            swaps = 0;
            if (vet.Length <= 1) return vet;

            int maxValue = GetMaxValue(vet);
            for (int exp = 1; maxValue / exp > 0; exp *= 10)
            {
                CountingSort(vet, exp);
            }

            PrintNumbers();
            return vet;
        }

        private int GetMaxValue(int[] vet)
        {
            int maxValue = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                comparisons++;
                if (vet[i] > maxValue) { maxValue = vet[i]; }
            }
            return maxValue;
        }

        private void CountingSort(int[] vet, int exp)
        {
            int[] count = new int[10];
            int[] ordered = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)
            {
                count[(vet[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                int digit = (vet[i] / exp) % 10;
                ordered[count[digit] - 1] = vet[i];
                count[digit]--;
                swaps++;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = ordered[i];
            }
        }

    }
}