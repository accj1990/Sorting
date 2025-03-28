namespace Sorting.sorting.simple
{
    static class SelectionSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
            }

            return vet;
        }
    }
}
