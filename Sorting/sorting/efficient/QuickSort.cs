namespace Sorting.sorting.efficient
{
    static class QuickSort
    {
        public static int[] Sorting(int[] vet)
        {
            Algorithm(vet, 0, vet.Length - 1);
            return vet;
        }

        private static void Algorithm(int[] vet, int left, int right)
        {
            if (left >= right) return;

            int i = left, j = right;
            int pivo = vet[(left + right) / 2];

            while (i <= j)
            {
                while (vet[i] < pivo) i++;
                while (vet[j] > pivo) j--;
                if (i <= j)
                {
                    Swap(vet, i, j);
                    i++;
                    j--;
                }
            }

            if (left < j) Algorithm(vet, left, j);
            if (i < right) Algorithm(vet, i, right);
        }

        private static void Swap(int[] vet, int left, int right)
        {
            int temp = vet[left];
            vet[left] = vet[right];
            vet[right] = temp;
        }
    }
}