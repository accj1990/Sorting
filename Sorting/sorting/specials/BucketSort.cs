using Sorting.sorting.simple;

namespace Sorting.sorting.specials
{
    class BucketSort : AbstractOrder
    {
        public int[] Sorting(int[] vet)
        {
            assignments = 0;
            comparisons = 0;
            swaps = 0;

            if (vet == null || vet.Length <= 1)
                return vet;

            int maxValue = vet.Max();
            int minValue = vet.Min();
            assignments += 2; 

            int bucketCount = vet.Length;
            assignments++;

            List<List<int>> buckets = new List<List<int>>(bucketCount);
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new List<int>());
                assignments++;
            }

            // distribuindo os elementos nos baldes
            for (int i = 0; i < vet.Length; i++)
            {
                int bucketIndex = (int)(((float)(vet[i] - minValue) / (maxValue - minValue + 1)) * bucketCount);
                buckets[bucketIndex].Add(vet[i]);
                assignments++; 
            }

            // ordenando cada balde individualmente e juntando
            int index = 0;
            assignments++; 

            foreach (var bucket in buckets)
            {
                InsertionSort(bucket);

                foreach (var value in bucket)
                {
                    vet[index] = value;
                    assignments+=2; 
                    swaps++;       
                    index++;
                }
            }

            PrintNumbers();
            return vet;
        }

        private void InsertionSort(List<int> bucket)
        {
            for (int i = 1; i < bucket.Count; i++)
            {
                int key = bucket[i];
                assignments++;

                int j = i - 1;
                assignments++;

                while (j >= 0)
                {
                    comparisons++; 

                    if (bucket[j] > key)
                    {
                        comparisons++;
                        bucket[j + 1] = bucket[j];
                        assignments+=2;
                        swaps++;       
                        j--;
                    }
                    else
                    {
                        comparisons++;
                        break;
                    }
                }

                bucket[j + 1] = key;
                assignments++;
                swaps++;      
            }
        }
    }
}