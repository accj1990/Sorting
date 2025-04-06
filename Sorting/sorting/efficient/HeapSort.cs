using System.Security.Cryptography;

namespace Sorting.sorting.efficient
{
    class HeapSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            comparisons = 0;
            swaps = 0;


            for (int i = 2; i <= vet.Length; i++) { Build(vet, i); }

            int size = vet.Length;
            while (size > 1)
            {
                Swap(vet, 0, size - 1);
                swaps++;
                size--;
                Rebuild(vet, size);
            }

            PrintNumbers();
            return vet;
        }

        private void Build(int[] vet, int size)
        {
            for (int i = size - 1; i > 0 && vet[i] > vet[(i - 1) / 2]; i = (i - 1) / 2)
            {
                comparisons++;
                Swap(vet, i, (i - 1) / 2);
                swaps++;
            }
        }

        private void Rebuild(int[] vet, int size)
        {
            int i = 0;
            while (HasChild(i, size))
            {
                int child = GetLargestIndex(vet, i, size);
                comparisons++;
                if (vet[i] < vet[child])
                {
                    Swap(vet, i, child);
                    swaps++;
                    i = child;
                }
                else { break; }
            }
        }

        private bool HasChild(int i, int size) { return (2 * i + 1) < size; }

        private int GetLargestIndex(int[] vet, int i, int size)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            comparisons++;
            if (right < size && vet[right] > vet[left]) { return right; }
            return left;
        }

        private void Swap(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }
    }
}