using Sorting.sorting.adapted;
using Sorting.sorting.efficient;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        // int[] vet = { 9, 7, 10, 8, 6, 2, 4, 3, 5, 1 };
        // QuickSort quickSort = new QuickSort();
        //int[] ordered = quickSort.Sorting(vet);

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