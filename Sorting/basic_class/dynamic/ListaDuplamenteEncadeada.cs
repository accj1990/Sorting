using System;

namespace Sorting.basic_class.dynamic
{
    class ListaDuplamenteEncadeada
    {
        private Celula? primeiro;
        private Celula? ultimo;

        public ListaDuplamenteEncadeada()
        {
            primeiro = null;
            ultimo = null;
        }

        public void InserirFim(int valor)
        {
            Celula nova = new Celula(valor);

            if (primeiro == null)
            {
                primeiro = nova;
                ultimo = nova;
            }
            else
            {
                ultimo!.prox = nova;
                nova.ant = ultimo;
                ultimo = nova;
            }
        }

        public void InserirInicio(int valor)
        {
            Celula nova = new Celula(valor);

            if (primeiro == null)
            {
                primeiro = nova;
                ultimo = nova;
            }
            else
            {
                nova.prox = primeiro;
                primeiro.ant = nova;
                primeiro = nova;
            }
        }

        public void Mostrar()
        {
            Console.Write("Lista: ");
            for (Celula? i = primeiro; i != null; i = i.prox)
            {
                Console.Write(i.valor + " ");
            }
            Console.WriteLine();
        }

        public void MostrarReverso()
        {
            Console.Write("Lista reversa: ");
            for (Celula? i = ultimo; i != null; i = i.ant)
            {
                Console.Write(i.valor + " ");
            }
            Console.WriteLine();
        }

        public bool Remover(int valor)
        {
            for (Celula? i = primeiro; i != null; i = i.prox)
            {
                if (i.valor == valor)
                {
                    if (i.ant != null)
                        i.ant.prox = i.prox;
                    else
                        primeiro = i.prox;

                    if (i.prox != null)
                        i.prox.ant = i.ant;
                    else
                        ultimo = i.ant;

                    return true;
                }
            }

            return false;
        }
        
        public void OrdenarQuickSort()
        {
            QuickSort(primeiro, ultimo);
        }

        #region Ordenação
        private void QuickSort(Celula? esquerda, Celula? direita)
        {
            if (esquerda != null && direita != null && esquerda != direita && esquerda != direita.prox)
            {
                Celula pivo = Particionar(esquerda, direita);
                QuickSort(esquerda, pivo.ant);
                QuickSort(pivo.prox, direita);
            }
        }

        private Celula Particionar(Celula esquerda, Celula direita)
        {
            int pivoValor = direita.valor;
            Celula? i = esquerda.ant;

            for (Celula? j = esquerda; j != direita; j = j.prox)
            {
                if (j.valor <= pivoValor)
                {
                    i = (i == null) ? esquerda : i.prox;
                    Trocar(i, j);
                }
            }

            i = (i == null) ? esquerda : i.prox;
            Trocar(i, direita);
            return i!;
        }

        private void Trocar(Celula a, Celula b)
        {
            int temp = a.valor;
            a.valor = b.valor;
            b.valor = temp;
        }
        #endregion

    }
}
