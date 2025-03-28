namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            int j, h, x, nn;
            for (h = 1; h <= vet.Length; h = (3 * h + 1))
            {
                while (h > 1)
                {
                    h /= 3;
                    for (int k = 0; k < h; k++)
                    {
                        nn = ((vet.Length / h) + ((vet.Length % h > k) ? 1 : 0));
                        for (int i = 1; i < nn; i++)
                        {
                            x = vet[(i * h) + k];
                            j = i - 1;
                            while (j >= 0 && vet[j * h + k] > x)
                            {
                                vet[((j + 1) * h) + k] = vet[(j * h) + k];
                                j--;
                            }
                            vet[((j + 1) * h) + k] = x;
                        }
                    }
                }
            }
            return vet;
        }
    }
}
