namespace Sorting.sorting.efficient
{
    class MergeSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;
          
            if (vet == null || vet.Length <= 1)
                return vet;

            Algorithm(vet, 0, vet.Length - 1);

            PrintNumbers(); 
            return vet;
        }

        private void Algorithm(int[] vet, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Algorithm(vet, left, middle);
                Algorithm(vet, middle + 1, right);

                Interleave(vet, left, middle, right);
            }
        }

        private void Interleave(int[] vet, int left, int middle, int right)
        {
            int nLeft = (middle + 1) - left;
            int nRight = right - middle;

            int[] vetLeft = new int[nLeft + 1];
            int[] vetRight = new int[nRight + 1];

            vetLeft[nLeft] = vetRight[nRight] = 0x7FFFFFFF;

            int iLeft, iRight, i;

            for (iLeft = 0; iLeft < nLeft; iLeft++)
            {
                vetLeft[iLeft] = vet[left + iLeft];
            }

            for (iRight = 0; iRight < nRight; iRight++)
            {
                vetRight[iRight] = vet[(middle + 1) + iRight];
            }

            for (iLeft = iRight = 0, i = left; i <= right; i++)
            {
                comparisons++;
                if (vetLeft[iLeft] <= vetRight[iRight])
                {
                    vet[i] = vetLeft[iLeft++];
                }
                else
                {
                    vet[i] = vetRight[iRight++];
                    swaps++;
                }

            }
        }
    }
}