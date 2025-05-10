namespace Sorting.sorting.efficient
{
     class QuickSort : AbstractOrder
    {
        public  int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            Algorithm(vet, 0, vet.Length - 1);

            PrintNumbers();
            return vet;
        }

        private  void Algorithm(int[] vet, int left, int right)
        {
            if (left >= right) return;

            int i = left, j = right;
            int pivot = vet[(left + right) / 2];

            while (i <= j)
            {
                while (vet[i] < pivot) { i++; comparisons++; }
                while (vet[j] > pivot) { j--; comparisons++; }
                if (i <= j)
                {
                    Swap(vet, i, j);
                    swaps++;
                    i++;
                    j--;
                }
            }

            if (left < j) Algorithm(vet, left, j);
            if (i < right) Algorithm(vet, i, right);
        }

        private  void Swap(int[] vet, int left, int right)
        {
            int temp = vet[left];
            vet[left] = vet[right];
            vet[right] = temp;
        }
    }
}