namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static int[] Sorting(int[] vet)
        {
            int maxValue = -1;

            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                }
            }

            for (int exponent = 1; maxValue / exponent > 0; exponent *= 10)
            {
                CountingSortRadix(vet, vet.Length, exponent);
            }
            return vet;
        }

        public static void CountingSortRadix(int[] vet, int size, int exponent)
        {
            int[] outputArr = new int[size];
            int[] occurences = new int[10];

            for (int i = 0; i < 10; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                occurences[(vet[i] / exponent) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                occurences[i] += occurences[i - 1];
            }

            for (int i = size - 1; i >= 0; i--)
            {
                outputArr[occurences[(vet[i] / exponent) % 10] - 1] = vet[i];
                occurences[(vet[i] / exponent) % 10]--;
            }

            for (int i = 0; i < size; i++)
            {
                vet[i] = outputArr[i];
            }
        }
    }
}
