namespace Sorting.sorting.specials
{
    class CountingSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            comparisons = 0;
            swaps = 0;

            int maxValue = GetMaxValue(vet);

            int[] count = new int[maxValue + 1];
            int[] ordered = new int[vet.Length];

            foreach (var number in vet)
            {
                count[number]++;
            }
            for (int i = 1; i <= maxValue; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = vet.Length - 1; i >= 0; i--)
            {
                swaps++;
                ordered[count[vet[i]] - 1] = vet[i];
                count[vet[i]]--;
            }

            PrintNumbers();
            return ordered;
        }

        private int GetMaxValue(int[] vet)
        {
            int maxValue = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                comparisons++;
                if (vet[i] > maxValue) { maxValue = vet[i]; }
            }
            return maxValue;
        }
    }
}
