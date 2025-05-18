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
                case Sortings.BUBBLE_SORT:
                    BubbleSort b = new BubbleSort();
                    ordered = b.Sorting(vet);
                    break;

                case Sortings.SELECTION_SORT:
                    SelectionSort s = new SelectionSort();
                    ordered = s.Sorting(vet);
                    break;

                case Sortings.INSERTION_SORT:
                    InsertionSort i = new InsertionSort();
                    ordered = i.Sorting(vet);
                    break;

                case Sortings.BUCKET_SORT:
                    BucketSort k = new BucketSort();
                    ordered = k.Sorting(vet);
                    break;

                case Sortings.COUNTING_SORT:
                    CountingSort c = new CountingSort();
                    ordered = c.Sorting(vet);
                    break;

                case Sortings.RADIX_SORT:
                    RadixSort r = new RadixSort();
                    ordered = r.Sorting(vet);
                    break;

                case Sortings.SHELL_SORT:
                    ShellSort l = new ShellSort();
                    ordered = l.Sorting(vet);
                    break;

                case Sortings.QUICK_SORT:
                    QuickSort q = new QuickSort();
                    ordered = q.Sorting(vet);
                    break;

                case Sortings.MERGE_SORT:
                    MergeSort m = new MergeSort();
                    ordered = m.Sorting(vet);
                    break;

                case Sortings.HEAP_SORT:
                    HeapSort h = new HeapSort();
                    ordered = h.Sorting(vet);
                    break;
            }
        }
    }
}
