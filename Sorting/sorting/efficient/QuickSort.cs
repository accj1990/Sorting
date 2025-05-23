namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] vet, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = vet[leftIndex];

            while (i <= j)
            {
                while (vet[i] < pivot)
                {
                    i++;
                }

                while (vet[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                Sorting(vet, leftIndex, j);
            }

            if (i < rightIndex)
            {
                Sorting(vet, i, rightIndex);
            }

            return vet;
        }
    }
}
