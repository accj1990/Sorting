namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static void Sorting(int[] vet, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sorting(vet, left, middle);
                Sorting(vet, middle + 1, right);
                Interleave(vet, left, middle, right);
            }
        }

        private static void Interleave(int[] vet, int left, int middle, int rigth)
        {
            //Definir tamanho dos dois subarrays
            int nLeft = (middle + 1) - left;
            int nRight = rigth - middle;
            int[] vetLeft = new int[nLeft + 1];
            int[] vetRight = new int[nRight + 1];
            //Sentinela no final dos dois arrays
            vetLeft[nLeft] = vetRight[nRight] = 0x7FFFFFFF;

            int iEsq, iDir, i;
            //Inicializar primeiro subarray
            for (iEsq = 0; iEsq < nLeft; iEsq++)
            {
                vetLeft[iEsq] = vet[left + iEsq];
            }
            //Inicializar segundo subarray
            for (iDir = 0; iDir < nRight; iDir++)
            {
                vetRight[iDir] = vet[(middle + 1) + iDir];
            }
            //Intercalacao propriamente dita
            for (iEsq = iDir = 0, i = left; i <= rigth; i++)
            {
                vet[i] = (vetLeft[iEsq] <= vetRight[iDir]) ? vetLeft[iEsq++] : vetRight[iDir++];
            }
        }
    }
}