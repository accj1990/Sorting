namespace Sorting.sorting.efficient
{
    class ShellSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;
            
            int h = 1;
            assignments++;

            // definindo incremento inicial
            while (h < vet.Length / 3) { h = 3 * h + 1; assignments++;            }

            while (h >= 1)
            {
                for (int i = h; i < vet.Length; i++)
                {
                    int x = vet[i];
                    int j = i;

                    assignments += 2;
                    while (j >= h && vet[j - h] > x)
                    {
                        vet[j] = vet[j - h];
                        j -= h;

                        comparisons++; 
                        assignments+=2; 
                        swaps++;
                    }
                    if (j >= h) { comparisons++; }

                    vet[j] = x;
                    assignments++;
                    swaps++;
                }

                h /= 3; // reducao do gap
                assignments++;
            }

            PrintNumbers();
            return vet;
        }
    }
}
