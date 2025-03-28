namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static int[] Sorting(int[] vet)
        {
            if (vet == null || vet.Length <= 1)
                return vet;

            Algorithm(vet, 0, vet.Length - 1);
            return vet;
        }

        private static void Algorithm(int[] vet, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Algorithm(vet, left, middle); 
                Algorithm(vet, middle + 1, right); 

                Interleave(vet, left, middle, right); 
            }
        }

        private static void Interleave(int[] vet, int left, int middle, int right)
        {
            int nLeft = (middle + 1) - left;
            int nRight = right - middle;

            int[] vetLeft = new int[nLeft + 1]; 
            int[] vetRight = new int[nRight + 1]; 

            vetLeft[nLeft] = vetRight[nRight] = 0x7FFFFFFF;

            int iEsq, iDir, i;

            for (iEsq = 0; iEsq < nLeft; iEsq++)
            {
                vetLeft[iEsq] = vet[left + iEsq];
            }

            for (iDir = 0; iDir < nRight; iDir++)
            {
                vetRight[iDir] = vet[(middle + 1) + iDir];
            }

            for (iEsq = iDir = 0, i = left; i <= right; i++)
            {
                vet[i] = (vetLeft[iEsq] <= vetRight[iDir]) ? vetLeft[iEsq++] : vetRight[iDir++];
            }
        }
    }
}