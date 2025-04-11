using System.Security.Cryptography;
using Sorting.enums;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;
using Sorting.sorting.specials;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Order(Sortings algorithm, int[] vet)
        {
            int[] ordered;

            switch (algorithm)
            {
                case Sortings.BUBBLESORT:
                    BubbleSort b = new BubbleSort();
                    ordered = b.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    SelectionSort s = new SelectionSort();
                    ordered = s.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    InsertionSort i = new InsertionSort();
                    ordered = i.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    BucketSort k = new BucketSort();
                    ordered = k.Sorting(vet);
                    break;

                case Sortings.COUNTINGSORT:
                    CountingSort c = new CountingSort();
                    ordered = c.Sorting(vet);
                    break;

                case Sortings.RADIXSORT:
                    RadixSort r = new RadixSort();
                    ordered = r.Sorting(vet);
                    break;

                case Sortings.SHELLSORT:
                    ShellSort l = new ShellSort();
                    ordered = l.Sorting(vet);
                    break;

                case Sortings.QUICKSORT:
                    QuickSort q = new QuickSort();
                    ordered = q.Sorting(vet);
                    break;

                case Sortings.MERGESORT:
                    MergeSort m = new MergeSort();
                    ordered = m.Sorting(vet);
                    break;

                case Sortings.HEAPSORT:
                    HeapSort h = new HeapSort();
                    ordered = h.Sorting(vet);
                    break;
            }
        }
    }
}
