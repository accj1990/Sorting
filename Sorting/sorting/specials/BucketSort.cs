namespace Sorting.sorting.specials
{
    class BucketSort
    {
        public static int[] Sorting(int[] vet)
        {
            int maxValue = vet[0];
            int minValue = vet[0];

            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > maxValue)
                {
                    maxValue = vet[i];
                }
                if (vet[i] < minValue)
                {
                    minValue = vet[i];
                }
            }

            LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

            for (int i = 0; i < vet.Length; i++)
            {
                if (bucket[vet[i] - minValue] == null)
                {
                    bucket[vet[i] - minValue] = new LinkedList<int>();
                }

                bucket[vet[i] - minValue].AddLast(vet[i]);
            }
            int index = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<int> node = bucket[i].First;
                    while (node != null)
                    {
                        vet[index] = node.Value;
                        node = node.Next;
                        index++;
                    }
                }
            }

            return vet;
        }
    }
}
