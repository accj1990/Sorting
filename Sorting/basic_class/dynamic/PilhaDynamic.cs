using System;

namespace Sorting.basic_class.dynamic
{
    public class PilhaDynamic
    {
        private Celula? topo;
        private int cont;

        public PilhaDynamic()
        {
            topo = null;
            cont = 0;
        }

        public void Empilhar(int valor)
        {
            Celula nova = new Celula(valor);
            nova.prox = topo;
            topo = nova;
            cont++;
        }

        public int Desempilhar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia!");
                return -1;
            }

            int valor = topo!.valor;
            topo = topo.prox;
            cont--;
            return valor;
        }

        public bool Vazia()
        {
            return topo == null;
        }

        public void Mostrar()
        {
            Console.Write("Pilha: ");
            for (Celula? i = topo; i != null; i = i.prox)
            {
                Console.Write(i.valor + " ");
            }
            Console.WriteLine();
        }
    }
}