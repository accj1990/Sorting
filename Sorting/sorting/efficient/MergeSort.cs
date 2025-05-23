namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static int[] Sorting(int[] vet, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Sorting(vet, leftIndex, middleIndex);
                Sorting(vet, middleIndex + 1, rightIndex);
                MergeVet(vet, leftIndex, middleIndex, rightIndex);
            }
            return vet;
        }

        public static void MergeVet(int[] Vet, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftIndexVetLength = middleIndex - leftIndex + 1;
            int rightIndexVetLength = rightIndex - middleIndex;
            int[] leftIndexTempVet = new int[leftIndexVetLength];
            int[] rightIndexTempVet = new int[rightIndexVetLength];
            int i, j;

            for (i = 0; i < leftIndexVetLength; ++i)
            {
                leftIndexTempVet[i] = Vet[leftIndex + i];
            }

            for (j = 0; j < rightIndexVetLength; ++j)
            {
                rightIndexTempVet[j] = Vet[middleIndex + 1 + j];
            }

            i = 0;
            j = 0;
            int k = leftIndex;

            while (i < leftIndexVetLength && j < rightIndexVetLength)
            {
                if (leftIndexTempVet[i] <= rightIndexTempVet[j])
                {
                    Vet[k++] = leftIndexTempVet[i++];
                }
                else
                {
                    Vet[k++] = rightIndexTempVet[j++];
                }
            }
            
            while (i < leftIndexVetLength)
            {
                Vet[k++] = leftIndexTempVet[i++];
            }

            while (j < rightIndexVetLength)
            {
                Vet[k++] = rightIndexTempVet[j++];
            }
        }
    }
}
