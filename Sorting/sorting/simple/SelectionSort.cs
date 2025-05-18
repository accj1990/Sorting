using System;

namespace Sorting.sorting.simple
{
    class SelectionSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            int min;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                min = i;
                assignments++;
                for (int j = i + 1; j < vet.Length; j++)
                {
                    comparisons++;
                    if (vet[j] < vet[min]) { min = j; assignments++; }
                }

                int temp = vet[i];
                vet[i] = vet[min];
                vet[min] = temp;
                swaps++;
                assignments += 3;
            }

            PrintNumbers();
            return vet;
        }
    }
}
