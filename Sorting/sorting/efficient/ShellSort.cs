namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            for (int interval = vet.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < vet.Length; i++)
                {
                    var currentKey = vet[i];
                    var k = i;
                    while (k >= interval && vet[k - interval] > currentKey)
                    {
                        vet[k] = vet[k - interval];
                        k -= interval;
                    }
                    vet[k] = currentKey;
                }
            }
            return vet;
        }
    }
}
