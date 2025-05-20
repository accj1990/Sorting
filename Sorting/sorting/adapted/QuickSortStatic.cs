using Sorting.basic_class.@static;

namespace Sorting.sorting.adapted
{
    internal class QuickSortStatic : AbstractOrder
    {
        public int[] Sorting(List list)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            Algorithm(list.list, 0, list.cont - 1);

            PrintNumbers();
            return list.list;
        }

        private void Algorithm(int[] list, int left, int right)
        {
            comparisons++;
            if (left >= right) return;

            int i = left, j = right;
            int pivot = list[(left + right) / 2];
            assignments += 3;

            while (i <= j)
            {
                comparisons++;
                while (list[i] < pivot) { i++; comparisons++; }
                while (list[j] > pivot) { j--; comparisons++; }
                if (i <= j)
                {
                    Swap(list, i, j);
                    swaps++;
                    i++;
                    j--;
                    assignments += 2;
                }
            }

            comparisons += 2;
            if (left < j) Algorithm(list, left, j);
            if (i < right) Algorithm(list, i, right);
        }

        private void Swap(int[] list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            assignments += 3;
        }
    }
}
