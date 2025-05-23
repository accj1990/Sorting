namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static int[] Sorting(int[] vet)
        {
            int size = vet.Length;
            int maxValue = -1;

            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                }
            }

            int[] occurrences = new int[maxValue + 1];
            
            for (int i = 0; i < maxValue + 1; i++)
            {
                occurrences[i] = 0;
            }
            for (int i = 0; i < size; i++)
            {
                occurrences[vet[i]]++;
            }
            for (int i = 0, j = 0; i <= maxValue; i++)
            {
                while (occurrences[i] > 0)
                {
                    vet[j] = i;
                    j++;
                    occurrences[i]--;
                }
            }
            return vet;
        }
    }
}
