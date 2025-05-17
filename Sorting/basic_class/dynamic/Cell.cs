using System.Drawing;

namespace Sorting.basic_class.dynamic
{
    class Cell
    {
        public int value;
        public Cell? next;
        public Cell? previous;

        public Cell(int value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }
}
