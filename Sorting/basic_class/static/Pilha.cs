using System;
using System.IO;
using System.Linq;

namespace Sorting.basic_class.@static
{
    class Pilha
    {
        public int[] pilha;
        public int topo; // guarda a posição do elemento do topo

        public Pilha(int n)
        {
            pilha = new int[n];
            topo = -1; // posição inválida
        }

        public bool Inserir(int item)
        {
            if (topo < pilha.Length - 1)
            {
                topo++;
                pilha[topo] = item;
                return true;
            }
            else
            {
                Console.WriteLine("Pilha cheia, não é possível inserir o " + item);
                return false;
            }
        }

        public int Remover()
        {
            if (topo != -1)
            {
                int tmp = pilha[topo];
                pilha[topo] = -1;
                topo--;
                return tmp;
            }
            else
            {
                Console.WriteLine("Pilha vazia, por isso não é possível remover elemento.");
                return -1;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine(" Pilha ");

            for (int i = topo; i > -1; i--)
            {
                Console.WriteLine(pilha[i]);
            }
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
        //     Pilha pilha = new Pilha(vector.Length);
        //     
        //     foreach (int item in vector)
        //     {
        //         pilha.Inserir(item);
        //     }
        //     
        //     pilha.Mostrar();//vetor antes
        //
        //     pilha.Remover();
        //     pilha.Remover();
        //     pilha.Remover();
        //     pilha.Inserir(2);
        //     pilha.Inserir(3);
        //     pilha.Inserir(45);
        //     
        //     Console.WriteLine( "Nova" );
        //     pilha.Mostrar(); // vetor depois das inserções e remoções
        // }
    }
}
