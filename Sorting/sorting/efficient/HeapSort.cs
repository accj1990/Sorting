using System.Security.Cryptography;

namespace Sorting.sorting.efficient
{
    static class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            for (int i = 2; i <= vet.Length; i++) { Build(vet, i); }

            int size = vet.Length;
            while (size > 1)
            {
                Swap(vet, 0, size - 1);
                size--;
                Rebuild(vet, size);
            }

            return vet;
        }

        private static void Build(int[] vet, int size)
        {
            for (int i = size - 1; i > 0 && vet[i] > vet[(i - 1) / 2]; i = (i - 1) / 2)
            {
                Swap(vet, i, (i - 1) / 2);
            }
        }

        private static void Rebuild(int[] vet, int size)
        {
            int i = 0;
            while (HasChild(i, size))
            {
                int filho = GetLargestIndex(vet, i, size);
                if (vet[i] < vet[filho])
                {
                    Swap(vet, i, filho);
                    i = filho;
                }
                else { break; }
            }
        }

        private static bool HasChild(int i, int size) { return (2 * i + 1) < size; }

        private static int GetLargestIndex(int[] vet, int i, int size)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (right < size && vet[right] > vet[left]) { return right; }
            return left;
        }

        private static void Swap(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }
    }
}