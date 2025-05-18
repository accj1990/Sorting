namespace Sorting.sorting.specials
{
    class CountingSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            int maxValue = GetMaxValue(vet);
            assignments++;

            int[] count = new int[maxValue + 1];
            int[] ordered = new int[vet.Length];
            assignments += (maxValue + 1); 
            assignments += vet.Length;    

            foreach (var number in vet)
            {
                count[number]++;
                assignments++; 
            }

            for (int i = 1; i <= maxValue; i++)
            {
                count[i] += count[i - 1];
                assignments++; 
            }

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                int value = vet[i];
                int pos = count[value] - 1;
                assignments+=4; 

                ordered[pos] = value;
                swaps++;       

                count[value]--;
            }

            PrintNumbers();
            return ordered;
        }

        private int GetMaxValue(int[] vet)
        {
            int maxValue = vet[0];
            assignments++; 

            for (int i = 1; i < vet.Length; i++)
            {
                comparisons++;
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                    assignments++;
                }
            }

            return maxValue;
        }
    }
}
