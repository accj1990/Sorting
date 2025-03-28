namespace Sorting.sorting.efficient
{
    static class QuickSort
    {
        public static void Sorting(int[] vet, int left, int right)
        {
            int i = left, j = right, pivo = vet[(left + right) / 2];
            while (i <= j)
            {
                while (vet[i] < pivo) { i++; }
                while (vet[j] > pivo) { j--; }
                if (i <= j) { Swap(vet, i, j); i++; j--; }
            }
            if (left < j) { Sorting(vet, left, j); }
            if (i < right) { Sorting(vet, i, right); }
        }

        private static int[] Swap(int[] vet, int left, int right)
        {
            return vet;
        }
    }
}