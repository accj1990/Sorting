using Sorting.enums;

namespace Sorting.basic_class.dynamic
{
    class DynamicList // or DoublyLinkedList
    {
        public Cell? firstCell;
        public Cell? lastCell;
        public int cont;

        public DynamicList() { firstCell = lastCell = null; cont = 0; }


        public void Insert(int item, Position anchor, int position = 0)
        {
            bool b = false;
            switch (anchor)
            {
                case Position.START: b = InsertInStart(item); break;
                case Position.CUSTOM: b = InsertInPosition(item, position); break;
                case Position.END: b = InsertInEnd(item); break;
            }
            if (b == true) { cont++; }
        }

        public void Remove(Position anchor, int position)
        {
            bool b = false;
            switch (anchor)
            {
                case Position.START: RemoveInStart(); break;
                case Position.CUSTOM: RemoveInPosition(position); break;
                case Position.END: RemoveInEnd(); break;
            }
            if (b == true) { cont--; }
        }

        #region Insert
        bool InsertInStart(int item)
        {
            Cell newCell = new Cell(item);
            if (firstCell == null)
            {
                firstCell = lastCell = newCell;
            }
            else
            {
                newCell.next = firstCell;
                firstCell.previous = newCell;
                firstCell = newCell;
            }
            return true;
        }

        bool InsertInPosition(int item, int position)
        {
            if (position < 0) { Console.WriteLine("\nPosição inválida."); return false; }

            Cell newCell = new Cell(item);
            if (firstCell == null || position == 0)
            {
                return InsertInStart(item);
            }

            Cell? temp = firstCell;
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            if (temp == null || temp.next == null)
            {
                return InsertInEnd(item);
            }

            newCell.next = temp.next;
            newCell.previous = temp;
            temp.next!.previous = newCell;
            temp.next = newCell;

            return true;
        }

        bool InsertInEnd(int item)
        {
            Cell newCell = new Cell(item);
            if (lastCell == null)
            {
                firstCell = lastCell = newCell;
            }
            else
            {
                lastCell.next = newCell;
                newCell.previous = lastCell;
                lastCell = newCell;
            }
            return true;
        }
        #endregion

        #region Remove
        bool RemoveInStart()
        {
            if (firstCell == null) { Console.WriteLine("\nLista está vazia."); return false; }

            firstCell = firstCell.next;
            if (firstCell != null) firstCell.previous = null;
            else lastCell = null;

            return true;
        }

        bool RemoveInPosition(int position)
        {
            if (firstCell == null || position < 0) { Console.WriteLine("\nPosição inválida."); return false; }

            Cell? temp = firstCell;
            for (int i = 0; temp != null && i < position; i++)
            {
                temp = temp.next;
            }

            if (temp == null) { Console.WriteLine("\nPosição fora dos limites."); return false; }

            if (temp.previous != null) temp.previous.next = temp.next;
            else firstCell = temp.next;

            if (temp.next != null) temp.next.previous = temp.previous;
            else lastCell = temp.previous;

            return true;
        }

        bool RemoveInEnd()
        {
            if (lastCell == null) { Console.WriteLine("\nLista está vazia."); return false; }

            lastCell = lastCell.previous;
            if (lastCell != null) lastCell.next = null;
            else firstCell = null;

            return true;
        }
        #endregion

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
