namespace Sorting.sorting.specials
{
    static class RadixSort
    {
        public static int[] Sorting(int[] vet)
        {
            if (vet.Length <= 1) return vet;

            int maxValue = GetMaxValue(vet);
            for (int exp = 1; maxValue / exp > 0; exp *= 10)
            {
                CountingSort(vet, exp);
            }

            return vet;
        }

        private static int GetMaxValue(int[] vet)
        {
            int maxValue = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > maxValue) { maxValue = vet[i]; }
            }
            return maxValue;
        }

        private static void CountingSort(int[] vet, int exp)
        {
            int[] count = new int[10];
            int[] ordered = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)
            {
                count[(vet[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                int digit = (vet[i] / exp) % 10;
                ordered[count[digit] - 1] = vet[i];
                count[digit]--;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = ordered[i];
            }
        }
    }
}