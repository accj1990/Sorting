using Sorting.sorting.simple;

namespace Sorting.sorting.specials
{
    class BucketSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length; j++)
                {
                    comparisons++;
                    if (vet[i] < vet[j])
                    {
                        var temp = vet[i];
                        vet[i] = vet[j];
                        vet[j] = temp;
                        swaps++;
                    }
                }
            }

            PrintNumbers();
            return vet;
        }
    }
}
