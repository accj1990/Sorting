namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            for (int i = vet.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(vet, vet.Length, i);
            }

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                int tempint = vet[0];
                vet[0] = vet[i];
                vet[i] = tempint;
                Heapify(vet, i, 0);
            }
            
            return vet;
        }

        public static void Heapify(int[] vet, int size, int index)
        {
            int largestIndex = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < size && vet[leftChild] > vet[largestIndex])
            {
                largestIndex = leftChild;
            }

            if (rightChild < size && vet[rightChild] > vet[largestIndex])
            {
                largestIndex = rightChild;
            }
            
            if (largestIndex != index)
            {
                int tempint = vet[index];
                vet[index] = vet[largestIndex];
                vet[largestIndex] = tempint;
                Heapify(vet, size, largestIndex);
            }
        }
    }
}
