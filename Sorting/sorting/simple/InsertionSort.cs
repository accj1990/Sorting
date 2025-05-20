namespace Sorting.sorting.simple
{
    class InsertionSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            int j, x;
            for (int i = 1; i < vet.Length; i++)
            {
                x = vet[i];
                assignments++;
                j = i - 1;

                comparisons++;
                while (j >= 0 && vet[j] > x)
                {
                    vet[j + 1] = vet[j];
                    assignments++;
                    swaps++;
                    j--;
                }

                vet[j + 1] = x;
                assignments++;
            }

            PrintNumbers();
            return vet;
        }
    }
}
