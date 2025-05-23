using Sorting.enums;
using Sorting.sorting.simple;
using Sorting.sorting.specials;
using Sorting.sorting.efficient;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static int[] Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado = [0];

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    return ordenado;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    return ordenado;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
                    return ordenado;

                case Sortings.BUCKETSORT:
                    ordenado = BucketSort.Sorting(vet);
                    return ordenado;

                case Sortings.COUNTINGSORT:
                    ordenado = CountingSort.Sorting(vet);
                    return ordenado;

                case Sortings.RADIXSORT:
                    ordenado = RadixSort.Sorting(vet);
                    return ordenado;

                case Sortings.SHELLSORT:
                    ordenado = ShellSort.Sorting(vet);
                    return ordenado;

                case Sortings.QUICKSORT:
                    ordenado = QuickSort.Sorting(vet, 0, vet.Length - 1);
                    return ordenado;

                case Sortings.MERGESORT:
                    ordenado = MergeSort.Sorting(vet, 0, vet.Length - 1);
                    return ordenado;

                case Sortings.HEAPSORT:
                    ordenado = HeapSort.Sorting(vet);
                    return ordenado;
            }
            return ordenado;
        }
    }
}
