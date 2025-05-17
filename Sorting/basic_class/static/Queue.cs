namespace Sorting.basic_class.@static
{
    class Queue
    {
        public int[] queueArray;
        public int cont;
        public Queue(int n)
        {
            queueArray = new int[n];
            cont = 0;
        }

        public bool Insert(int item)
        {
            if (cont < queueArray.Length)
            {
                queueArray[cont] = item;
                cont++;
                return true;
            }
            else { Console.WriteLine($"\nNão é possível inserir '{item}', já que, a fila está cheia."); return false; }
        }

        public int Remove()
        {
            int temp = queueArray[0];
            for (int i = 0; i < cont - 1; i++)
            {
                queueArray[i] = queueArray[i + 1];
            }

            queueArray[cont - 1] = -1;
            cont--;
            return temp;
        }

        public void Print()
        {
            for (int i = 0; i < cont; i++) { Console.Write(queueArray[i] + " "); }
            Console.WriteLine(" ");
        }
    }
}
