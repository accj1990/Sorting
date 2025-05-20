using Sorting.basic_class.dynamic;

namespace Sorting.sorting.adapted
{
    internal class QuickSortDynamic : AbstractOrder
    {
        public int[] Sorting(DynamicList list)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            if (list.firstCell != null && list.lastCell != null)
                QuickSortRecursive(list.firstCell, list.lastCell);

            PrintNumbers();

            // vetor de retorno :D
            int[] result = new int[list.cont];
            Cell? current = list.firstCell;
            for (int i = 0; i < list.cont && current != null; i++)
            {
                result[i] = current.value;
                current = current.next;
            }

            return result;
        }

        private void QuickSortRecursive(Cell? left, Cell? right)
        {
            if (left == null || right == null || left == right || left == right.next) { return; }

            Cell? pivot = Partition(left, right, out Cell? newLeft, out Cell? newRight);
            if (newLeft != null && pivot != null && newLeft != pivot) { QuickSortRecursive(newLeft, pivot.previous); }
            if (newRight != null && pivot != null && newRight != pivot) { QuickSortRecursive(pivot.next, newRight); }
        }

        private Cell Partition(Cell left, Cell right, out Cell newLeft, out Cell newRight)
        {
            int pivotValue = right.value;
            assignments++;

            Cell? i = left.previous;
            Cell? j = left;

            while (j != right)
            {
                comparisons++;
                if (j!.value < pivotValue)
                {
                    i = (i == null) ? left : i.next;
                    Swap(i!, j);
                    swaps++;
                    assignments += 3;
                }
                j = j.next;
            }

            i = (i == null) ? left : i.next;
            Swap(i!, right);
            swaps++;
            assignments += 3;

            newLeft = left;
            newRight = right;

            return i;
        }

        private void Swap(Cell a, Cell b)
        {
            int temp = a.value;
            a.value = b.value;
            b.value = temp;
        }
    }
}