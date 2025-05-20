namespace Sorting.sorting.efficient
{
    class MergeSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            comparisons++;
            if (vet == null || vet.Length <= 1) return vet;

            Algorithm(vet, 0, vet.Length - 1);

            PrintNumbers();
            return vet;
        }

        private void Algorithm(int[] vet, int left, int right)
        {
            comparisons++;
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                assignments++;

                Algorithm(vet, left, middle);
                Algorithm(vet, middle + 1, right);

                Merge(vet, left, middle, right);
            }
        }

        private void Merge(int[] vet, int left, int middle, int right)
        {
            int nLeft = middle - left + 1;
            int nRight = right - middle;
            assignments += 2;

            int[] vetLeft = new int[nLeft];
            int[] vetRight = new int[nRight];
            assignments += nLeft + nRight;

            // copiando dados para vetores temporarios
            for (int i = 0; i < nLeft; i++)
            {
                vetLeft[i] = vet[left + i];
                assignments++;
            }

            for (int j = 0; j < nRight; j++)
            {
                vetRight[j] = vet[middle + 1 + j];
                assignments++;
            }

            int k = 0, l = 0, m = left;
            assignments += 3;

            // merge propriamente dito
            while (k < nLeft && l < nRight)
            {
                comparisons++;
                if (vetLeft[k] <= vetRight[l])
                {
                    vet[m++] = vetLeft[k++];
                    assignments++;
                    swaps++;
                }
                else
                {
                    vet[m++] = vetRight[l++];
                    assignments++;
                    swaps++;
                }
            }

            // copiando elementos restantes de vetLeft, se houver
            while (k < nLeft)
            {
                comparisons++; 
                vet[m++] = vetLeft[k++];
                assignments++;
                swaps++;
            }

            // copiando elementos restantes de vetRight, se houver
            while (l < nRight)
            {
                comparisons++;
                vet[m++] = vetRight[l++];
                assignments++;
                swaps++;
            }
        }
    }
}