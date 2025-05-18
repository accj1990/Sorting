namespace Sorting.sorting
{
    internal abstract class AbstractOrder
    {
        public long comparisons = 0;
        public long assignments = 0;
        public long time = 0;
        public long swaps = 0;

        public void PrintNumbers()
        {
            Console.WriteLine($"Número de atribuições: {assignments}");
            Console.WriteLine($"Número de comparações: {comparisons}");
            Console.WriteLine($"Número de trocas: {swaps}");
            Console.WriteLine($"Tempo de execução: {time}");
        }
    }
}
