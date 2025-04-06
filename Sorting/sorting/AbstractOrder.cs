using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.sorting
{
    internal abstract class AbstractOrder
    {
        public long comparisons = 0;
        public long swaps = 0;
        public long assignments = 0;

        public void PrintNumbers()
        {
            Console.WriteLine($"Número de atribuições: {assignments}");
            Console.WriteLine($"Número de comparações: {comparisons}");
            Console.WriteLine($"Número de trocas: {swaps}");
        }
    }
}
