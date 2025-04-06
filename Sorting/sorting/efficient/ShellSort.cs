namespace Sorting.sorting.efficient
{
    class ShellSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            int j, h, x, nn;
            for (h = 1; h <= vet.Length; h = (3 * h + 1)) ;
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
                            comparisons++;
                            vet[((j + 1) * h) + k] = vet[(j * h) + k];
                            swaps++;
                            j--;
                        }
                        vet[((j + 1) * h) + k] = x;
                        swaps++;
                    }
                }
            }

            PrintNumbers();
            return vet;
        }
    }
}
