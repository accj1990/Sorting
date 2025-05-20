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

            // construcao do heap máximo 
            for (int i = vet.Length / 2 - 1; i >= 0; i--)
            {
                Rebuild(vet, vet.Length, i);
            }

            // extracao dos elementos do heap
            for (int size = vet.Length - 1; size > 0; size--)
            {
                Swap(vet, 0, size);
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

            // verificando filho da esquerda
            if (left < size)
            {
                comparisons++;
                if (vet[left] > vet[largest])
                {
                    largest = left;
                    assignments++;
                }
            }

            // verificando filho da direita
            if (right < size)
            {
                comparisons++;
                if (vet[right] > vet[largest])
                {
                    largest = right;
                    assignments++;
                }
            }

            comparisons++;
            if (largest != i)
            {
                Swap(vet, i, largest);
                Rebuild(vet, size, largest);
            }
        }

        private void Swap(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;

            assignments += 3;
            swaps++;
        }
    }
}