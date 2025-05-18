using System.ComponentModel;

namespace Sorting.enums
{
    enum Sortings
    {
        [Description("BUBBLESORT")]
        BUBBLE_SORT = 1,

        [Description("SELECTION")]
        SELECTION_SORT = 2,

        [Description("INSERTION")]
        INSERTION_SORT = 3,

        [Description("BUCKETSORT")]
        BUCKET_SORT = 4,

        [Description("COUNTINGSORT")]
        COUNTING_SORT = 5,

        [Description("RADIXSORT")]
        RADIX_SORT = 6,

        [Description("SHELLSORT")]
        SHELL_SORT = 7,

        [Description("QUICKSORT")]
        QUICK_SORT = 8,

        [Description("MERGESORT")]
        MERGE_SORT = 9,

        [Description("HEAPSORT")]
        HEAP_SORT = 10,
    }
}
