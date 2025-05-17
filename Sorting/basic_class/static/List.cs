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
                case Position.START: InsertInStart(item); break;
                case Position.CUSTOM: InsertInPosition(item, position); break;
                case Position.END: InsertInEnd(item); break;
            }
        }

        public void Remove(Position anchor, int position)
        {
            switch (anchor)
            {
                case Position.START: RemoveInStart(); break;
                case Position.CUSTOM: RemoveInPosition(position); break;
                case Position.END: RemoveInEnd(); break;
            }
        }

        #region Insert
        bool InsertInStart(int item)
        {
            if (cont < list.Length)
            {
                for (int i = cont; i > 0; i--)
                {
                    list[i] = list[i - 1];
                }
                list[0] = item;
                cont++;
                return true;
            }
            else { Console.WriteLine($"\nNão é possível inserir '{item}', já que, a lista está cheia."); return false; }
        }

        bool InsertInPosition(int item, int position)
        {
            if (position < 0 || position > cont || cont >= list.Length) { Console.WriteLine($"\nNão é possível inserir '{item}' na posição '{position}'."); return false; }

            for (int i = cont; i > position; i--)
            {
                list[i] = list[i - 1];
            }
            list[position] = item;
            cont++;
            return true;
        }

        bool InsertInEnd(int item)
        {
            if (cont < list.Length)
            {
                list[cont] = item;
                cont++;
                return true;
            }
            else { Console.WriteLine($"\nNão é possível inserir '{item}', já que, a lista está cheia."); return false; }
        }
        #endregion

        #region Remove
        bool RemoveInStart()
        {
            if (cont == 0) { Console.WriteLine("\nNão é possível remover um elemento, já que, a lista está vazia."); return false; }


            for (int i = 0; i < cont - 1; i++)
            {
                list[i] = list[i + 1];
            }
            cont--;
            return true;
        }

        bool RemoveInPosition(int position)
        {
            if (position < 0 || position >= cont) { Console.WriteLine($"\nNão é possível remover na posição '{position}', índice inválido."); return false; }

            for (int i = position; i < cont - 1; i++)
            {
                list[i] = list[i + 1];
            }
            cont--;
            return true;
        }

        bool RemoveInEnd()
        {
            if (cont == 0) { Console.WriteLine("\nNão é possível remover um elemento, já que, a lista está vazia."); return false; }

            cont--;
            return true;
        }
        #endregion

        public void Print()
        {
            for (int i = 0; i < cont; i++) { Console.Write(list[i] + " "); }
            Console.WriteLine(" ");
        }
    }
}