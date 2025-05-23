using System;
using System.IO;
using System.Linq;

namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            Console.WriteLine("Lista está cheia, não é possível inserir " + item);
            return false;
        }

        public bool InserirInicio(int item)
        {
            if (cont < lista.Length)
            {
                for (int i = cont; i > 0; i--)
                    lista[i] = lista[i - 1];

                lista[0] = item;
                cont++;
                return true;
            }
            Console.WriteLine("Lista cheia!");
            return false;
        }

        public bool InserirPosicao(int item, int pos)
        {
            if (cont < lista.Length && pos >= 0 && pos <= cont)
            {
                for (int i = cont; i > pos; i--)
                    lista[i] = lista[i - 1];

                lista[pos] = item;
                cont++;
                return true;
            }
            Console.WriteLine("Posição inválida ou lista cheia!");
            return false;
        }

        public int RemoverFim()
        {
            if (cont > 0)
            {
                cont--;
                return lista[cont];
            }
            Console.WriteLine("Lista vazia!");
            return -1;
        }

        public int RemoverInicio()
        {
            if (cont > 0)
            {
                int removido = lista[0];
                for (int i = 0; i < cont - 1; i++)
                    lista[i] = lista[i + 1];
                cont--;
                return removido;
            }
            Console.WriteLine("Lista vazia!");
            return -1;
        }

        public int RemoverPosicao(int pos)
        {
            if (pos >= 0 && pos < cont)
            {
                int removido = lista[pos];
                for (int i = pos; i < cont - 1; i++)
                    lista[i] = lista[i + 1];
                cont--;
                return removido;
            }
            Console.WriteLine("Posição inválida!");
            return -1;
        }

        public void Mostrar()
        {
            Console.Write("Lista: ");
            for (int i = 0; i < cont; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }

        #region Ordenação
        public void OrdenarQuickSort()
        {
            QuickSort(0, cont - 1);
        }

        private void QuickSort(int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int pivoIndex = Particionar(esquerda, direita);
                QuickSort(esquerda, pivoIndex - 1);
                QuickSort(pivoIndex + 1, direita);
            }
        }

        private int Particionar(int esquerda, int direita)
        {
            int pivo = lista[direita];
            int i = esquerda - 1;

            for (int j = esquerda; j < direita; j++)
            {
                if (lista[j] <= pivo)
                {
                    i++;
                    Trocar(i, j);
                }
            }

            Trocar(i + 1, direita);
            return i + 1;
        }

        private void Trocar(int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
        #endregion
        
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Buza\\Desktop\\AedsIISorting\\MateusBarcelos\\Sorting\\inputs\\1000000-aleatorios.txt";
            string content = File.ReadAllText(filePath);

            int[] numeros = content
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lista lista = new Lista(numeros.Length);

            foreach (int num in numeros)
            {
                lista.InserirFim(num);
            }

            Console.WriteLine("Lista preenchida. Iniciando ordenação...");

            var watch = System.Diagnostics.Stopwatch.StartNew();
            lista.OrdenarQuickSort();
            watch.Stop();

            Console.WriteLine($"Ordenação concluída em {watch.ElapsedMilliseconds} ms.");
        }
    }
}
