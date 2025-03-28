namespace Sorting.sorting.simple
{
    static class BubbleSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                    }
                }
            }

            return vet;
        }
    }
}
