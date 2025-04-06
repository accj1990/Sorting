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
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        comparisons++;
                        min = j;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
                swaps++;
            }

            PrintNumbers();
            return vet;
        }
    }
}
