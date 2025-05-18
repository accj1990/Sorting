namespace Sorting.basic_class.dynamic
{
    class DynamicPile
    {
        public Cell? topCell;
        public int cont;

        public DynamicPile() { topCell = null; cont = 0; }

        public bool Insert(int item)
        {
            Cell newCell = new Cell(item);

            if (topCell == null)
            {
                // se a pilha estiver vazia, o novo no é o topo
                topCell = newCell;
            }
            else
            {
                newCell.next = topCell;
                topCell = newCell;
            }
            cont++;
            return true;
        }

        public int Remove()
        {
            if (topCell == null)
            {
                Console.WriteLine("\nNão é possível remover um elemento, já que, a pilha está vazia.");
                return -1;
            }

            int value = topCell.value; // guardando o valor do topo
            topCell = topCell.next; // mvoendo o topo para o proximo no
            
            cont--;
            return value;
        }

        public void Print()
        {
            Cell? temp = topCell;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
    }
}
