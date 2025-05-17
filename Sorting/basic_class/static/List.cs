using Sorting.enums;

namespace Sorting.basic_class.@static
{
    class List
    {
        public int[] list;
        public int cont;

        public List(int n)
        {
            list = new int[n];
            cont = 0;
        }

        public void Insert(int item, Position anchor, int position = 0)
        {
            switch (anchor)
            {
                case Position.Start: InsertInStart(item); break;
                case Position.Custom: InsertInPosition(item, position); break;
                case Position.End: InsertInEnd(item); break;
            }
        }

        public void Remove(int item, Position anchor, int position)
        {
            switch (anchor)
            {
                case Position.Start: RemoveInStart(item); break;
                case Position.Custom: RemoveInPosition(item, position); break;
                case Position.End: RemoveInEnd(item); break;
            }
        }

        #region Insert
        bool InsertInStart(int item)
        {
            return true;// implemente
        }

        bool InsertInPosition(int item, int position)
        {
            return true;// implemente
        }

        bool InsertInEnd(int item)
        {
            if (cont < list.Length)
            {
                list[cont] = item;
                cont++;
                return true;
            }
            else { Console.WriteLine($"Não é possível inserir '{item}', já que, a lista está cheia."); return false; }
        }
        #endregion

        #region Remove
        bool RemoveInStart(int item)
        {
            return true;// implemente
        }

        bool RemoveInPosition(int item, int position)
        {
            return true;// implemente
        }

        bool RemoveInEnd(int item)
        {
            return true;// implemente
        }
        #endregion

        public void Print()
        {
            for (int i = 0; i < cont; i++) { Console.Write(list[i] + " "); }
            Console.WriteLine(" ");
        }
    }
}