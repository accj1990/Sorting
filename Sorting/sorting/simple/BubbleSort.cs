namespace Sorting.sorting.simple
{
    class BubbleSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = vet.Length - 1; j > i; j--)
                {
                    comparisons++; 
                    if (vet[j] < vet[j - 1])
                    {
                        int temp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;

                        assignments += 3;
                        swaps++; 
                    }
                }
            }

            PrintNumbers();
            return vet;
        }
    }
}
