using Sorting.enums;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;
using Sorting.sorting.specials;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Order(Sortings algoritmo, int[] vet)
        {
            int[] ordenado;

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    ordenado = BucketSort.Sorting(vet);
                    break;

                case Sortings.COUNTINGSORT:
                    ordenado = CountingSort.Sorting(vet);
                    break;

                case Sortings.RADIXSORT:
                    ordenado = RadixSort.Sorting(vet);
                    break;

                case Sortings.SHELLSORT:
                    ordenado = ShellSort.Sorting(vet);
                    break;

                case Sortings.QUICKSORT:
                    ordenado = QuickSort.Sorting(vet);
                    break;

                case Sortings.MERGESORT:
                    ordenado = MergeSort.Sorting(vet);
                    break;

                case Sortings.HEAPSORT:
                    ordenado = HeapSort.Sorting(vet);
                    break;
            }
        }
    }
}
