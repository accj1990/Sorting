namespace Sorting.basic_class.@static
{
    class Pile
    {
        public int[] pileArray;
        public int top; // guarda a posicao do elemento do topo
        public int cont => top;

        public Pile(int n)
        {
            pileArray = new int[n];
            top = -1; // posicao invalida
        }

        public bool Insert(int item)
        {
            if (top < pileArray.Length - 1)
            {
                top++;
                pileArray[top] = item;
                return true;
            }
            else { Console.WriteLine($"\nNão é possível inserir '{item}', já que, a pilha está cheia."); return false; }
        }

        public int Remove()
        {
            if (top != -1)
            {
                int temp = pileArray[top];
                pileArray[top] = -1;
                top--;
                return temp;
            }
            else { Console.WriteLine("\nNão é possível remover um elemento, já que, a pilha está vazia."); return -1; }
        }

        public void Print()
        {
            for (int i = top; i > -1; i--) { Console.WriteLine(pileArray[i]); }
        }
    }
}
