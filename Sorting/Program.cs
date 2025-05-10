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
            if (op == 1) { Menu.Options(); }

        } while (op == 1);
    }
}