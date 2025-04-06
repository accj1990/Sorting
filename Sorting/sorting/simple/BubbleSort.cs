namespace Sorting.sorting.simple
{
    class BubbleSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            comparisons = 0;
            swaps = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = vet.Length - 1; j > i; j--)
                {
                    comparisons++;
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                        swaps++;
                    }
                }
            }

            PrintNumbers();
            return vet;
        }
    }
}
