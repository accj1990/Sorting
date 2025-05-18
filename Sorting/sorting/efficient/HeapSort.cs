using System.Security.Cryptography;

namespace Sorting.sorting.efficient
{
    class HeapSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            // construcao do heap maximo
            for (int i = vet.Length / 2 - 1; i >= 0; i--) { Rebuild(vet, vet.Length, i); }

            for (int size = vet.Length - 1; size > 0; size--) // ordenacao
            {
                Swap(vet, 0, size);
                swaps++;
                Rebuild(vet, size, 0);
            }

            PrintNumbers();
            return vet;
        }

        private void Rebuild(int[] vet, int size, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            assignments += 3;

            // verificando filho esquerdo e direito
            if (left < size && vet[left] > vet[largest]) { largest = left; }
            if (right < size && vet[right] > vet[largest]) { largest = right; }
            comparisons=+2;

            // trocando e continuando reorganizando se necessário
            if (largest != i)
            {
                Swap(vet, i, largest);
                swaps++;
                Rebuild(vet, size, largest);
            }
        }

        private void Swap(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }
    }
}