namespace Sorting.sorting.efficient
{
    class MergeSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            if (vet == null || vet.Length <= 1) { return vet; }
            Algorithm(vet, 0, vet.Length - 1);

            PrintNumbers();
            return vet;
        }

        private void Algorithm(int[] vet, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Algorithm(vet, left, middle);
                Algorithm(vet, middle + 1, right);

                Merge(vet, left, middle, right);
            }
        }

        private void Merge(int[] vet, int left, int middle, int right)
        {
            int nLeft = middle - left + 1;
            int nRight = right - middle;

            int[] vetLeft = new int[nLeft];
            int[] vetRight = new int[nRight];

            // copinado os dados para os arrays temporarios
            for (int i = 0; i < nLeft; i++) { vetLeft[i] = vet[left + i]; assignments++; }
            for (int j = 0; j < nRight; j++) { vetRight[j] = vet[middle + 1 + j]; assignments++; }

            int k = 0, l = 0, m = left;

            // juntando os vetores ordenados de volta no array original
            while (k < nLeft && l < nRight)
            {
                comparisons++;
                if (vetLeft[k] <= vetRight[l]) { vet[m++] = vetLeft[k++]; }
                else { vet[m++] = vetRight[l++]; }

                assignments++;            }

            // copiando quaisquer elementos restantes da esquerda e dirieta
            while (k < nLeft) { vet[m++] = vetLeft[k++]; assignments++; }
            while (l < nRight) { vet[m++] = vetRight[l++]; assignments++; }
        }
    }
}