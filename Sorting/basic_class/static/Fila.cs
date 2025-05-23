using System;
using System.IO;
using System.Linq;

namespace Sorting.basic_class.@static
{
    class Fila
    {
        public int[] fila;
        public int cont;
        public Fila(int n)
        {
            fila = new int[n];
            cont = 0;
        }

        public bool Inserir(int item)
        {
            if (cont < fila.Length)
            {
                fila[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("\nFila está cheia!!! Não é possível inserir o " + item);
                return false;
            }
        }

        public int Remover()
        {
            int tmp = fila[0];
            for (int i = 0; i < cont - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[cont - 1] = -1;
            cont--;
            return tmp;
        }

        public void Mostrar()
        {
            Console.WriteLine(" Fila ");

            for (int i = 0; i < cont; i++)
            {
                Console.Write(fila[i] + " ");
            }

            Console.WriteLine(" ");

        }
        
        // static void Main(string[] args)
        // {
        //     string filePath = "C:\\Users\\Buza\\Desktop\\AedsIISorting\\MateusBarcelos\\Sorting\\inputs\\100-aleatorios.txt";
        //     
        //     string content = File.ReadAllText(filePath);
        //     
        //     int[] vector = content
        //         .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
        //         .Select(int.Parse)
        //         .ToArray();
        //     
        //     Fila fila = new Fila(vector.Length);
        //     
        //     foreach (int item in vector)
        //     {
        //         fila.Inserir(item);
        //     }
        //     
        //     fila.Mostrar();//vetor antes
        //
        //     fila.Remover();
        //     fila.Remover();
        //     fila.Remover();
        //     fila.Inserir(2);
        //     fila.Inserir(3);
        //     fila.Inserir(45);
        //     
        //     fila.Mostrar();// vetor depois das inserções e remoções
        // }
    }
}
