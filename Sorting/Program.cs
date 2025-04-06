using Sorting;
using Sorting.basic_class.@static;
using Sorting.manager;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        int op = 0;
        do
        {
            Console.WriteLine("Insira a opção desejada, o número '1' se deseja continuar o programa.\nCaso contrário, digite qualquer outro número inteiro.");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (op == 1) { Sorting.Menu.Options(); }

        } while (op == 1);
      
        // Fila, Pilha e Lista em alocação estática
        Fila f = new Fila(5);

        f.Inserir(1);
        f.Inserir(2);
        f.Inserir(3);
        f.Inserir(4);
        f.Inserir(5);

        f.Mostrar();

        f.Inserir(6); // não consigo inserir pois a fila está cheia

        f.Remover();

        f.Mostrar();

        f.Inserir(6);

        f.Mostrar();

        f.Remover();

        f.Remover();

        f.Remover();

        f.Mostrar();

        // Pilha
        Pilha p = new Pilha(5);

        p.Inserir(1);
        p.Inserir(2);
        p.Inserir(3);
        p.Inserir(4);
        p.Inserir(5);

        p.Mostrar();
        p.Inserir(6);

        p.Remover();
        p.Remover();

        p.Mostrar();
    }
}