namespace Sorting.basic_class.dynamic
{
    class DynamicQueue
    {
        public Cell? firstCell;
        public Cell? lastCell;

        public DynamicQueue() { firstCell = lastCell = null; }

        public void Insert(int item)
        {
            Cell newCell = new Cell(item);

            if (lastCell == null) { firstCell = lastCell = newCell; } // se a fila tiver vazia
            else
            {
                lastCell.next = newCell;
                lastCell = newCell;
            }
        }

        public void Remove()
        {
            // se a fila tiver vazia
            if (lastCell == null) { Console.WriteLine("\nNão é possível remover um elemento, já que, a fila dinâmica está vazia."); return; }

            // se o ultimo elemento for removido
            firstCell = firstCell.next;
            if (firstCell == null) { lastCell = null; }
        }

        public void Print()
        {
            Cell? temp = firstCell;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
