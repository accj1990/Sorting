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

            // definindo incremento inicial
            while (h < vet.Length / 3) { h = 3 * h + 1; }

            while (h >= 1)
            {
                for (int i = h; i < vet.Length; i++)
                {
                    int x = vet[i];
                    assignments++; 
                    int j = i;

                    while (j >= h && vet[j - h] > x)
                    {
                        comparisons++; 
                        vet[j] = vet[j - h];
                        assignments++; 
                        j -= h;
                    }

                    vet[j] = x;
                    assignments++; 
                }

                h /= 3; // reducao do gap
            }

            PrintNumbers();
            return vet;
        }
    }
}
