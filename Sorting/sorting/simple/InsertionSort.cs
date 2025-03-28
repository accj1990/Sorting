namespace Sorting.sorting.simple
{
    static class InsertionSort
    {
        public static int[] Sorting(int[] vet)
        {
            int j, x;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                j = i - 1;
                while (j >= 0 && vet[j] > x)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = x;
            }
            return vet;
        }
    }
}
