using Sorting.basic_class.dynamic;
using Sorting.basic_class.@static;
using Sorting.enums;
using Sorting.manager;
using Sorting.print;
using Sorting.sorting.adapted;
using Sorting.sorting.efficient;

public static class Menu
{
    private static int[] ChooseFile()
    {
        Console.WriteLine("Escolha o arquivo que será lido");
        Console.WriteLine("A - 10-aleatorios");
        Console.WriteLine("B - 100-aleatorios");
        Console.WriteLine("C - 1000-aleatorios");
        Console.WriteLine("D - 10000-aleatorios");
        Console.WriteLine("E - 100000-aleatorios");
        Console.WriteLine("F - 1000000-aleatorios");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));
        int[] vet = new int[1];

        Console.WriteLine(" ");
        switch (op)
        {
            case 'A': Console.WriteLine("Opção A: Arquivo '10-aleatorios' escolhido."); vet = new int[10]; vet = ManagerFileReader.File10(); break;
            case 'B': Console.WriteLine("Opção B: Arquivo '100-aleatorios' escolhido."); vet = new int[100]; vet = ManagerFileReader.File100(); break;
            case 'C': Console.WriteLine("Opção C: Arquivo '1000-aleatorios' escolhido."); vet = new int[1000]; vet = ManagerFileReader.File1000(); break;
            case 'D': Console.WriteLine("Opção D: Arquivo '10000-aleatorios' escolhido."); vet = new int[10000]; vet = ManagerFileReader.File10000(); break;
            case 'E': Console.WriteLine("Opção E: Arquivo '100000-aleatorios' escolhido."); vet = new int[100000]; vet = ManagerFileReader.File100000(); break;
            case 'F': Console.WriteLine("Opção F: Arquivo '1000000-aleatorios' escolhido."); vet = new int[1000000]; vet = ManagerFileReader.File1000000(); break;
        }
        Console.WriteLine(" "); return vet;
    }

    #region Order
    private static Sorting.enums.Sortings ChooseOrder(int[] vet)
    {
        Console.WriteLine("Escolha a ordenação que será executada");
        Console.WriteLine("A - Bubble Sort");
        Console.WriteLine("B - Selection Sort");
        Console.WriteLine("C - Insertion Sort");
        Console.WriteLine("D - Bucket Sort");
        Console.WriteLine("E - Counting Sort");
        Console.WriteLine("F - Radix Sort");
        Console.WriteLine("G - Shell Sort");
        Console.WriteLine("H - Quick Sort");
        Console.WriteLine("I - Merge Sort");
        Console.WriteLine("J - Heap Sort");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));
        Sorting.enums.Sortings algorithm = global::Sorting.enums.Sortings.BUBBLE_SORT;

        Console.WriteLine(" ");
        switch (op)
        {
            case 'A': Console.WriteLine("Opção A: Ordenação 'Bubble Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.BUBBLE_SORT; break;
            case 'B': Console.WriteLine("Opção B: Ordenação 'Selection Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.SELECTION_SORT; break;
            case 'C': Console.WriteLine("Opção C: Ordenação 'Insertion Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.INSERTION_SORT; break;
            case 'D': Console.WriteLine("Opção D: Ordenação 'Bucket Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.BUCKET_SORT; break;
            case 'E': Console.WriteLine("Opção E: Ordenação 'Counting Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.COUNTING_SORT; break;
            case 'F': Console.WriteLine("Opção F: Ordenação 'Radix Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.RADIX_SORT; break;
            case 'G': Console.WriteLine("Opção G: Ordenação 'Shell Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.SHELL_SORT; break;
            case 'H': Console.WriteLine("Opção H: Ordenação 'Quick Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.QUICK_SORT; break;
            case 'I': Console.WriteLine("Opção I: Ordenação 'Merge Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.MERGE_SORT; break;
            case 'J': Console.WriteLine("Opção J: Ordenação 'Heap Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.HEAP_SORT; break;
        }
        Console.WriteLine(" "); return algorithm;
    }

    private static void Sorting() // solicitando ao usuario algoritmo e arquivo desejados
    {
        int[] vet = ChooseFile();
        Sorting.enums.Sortings algorithm = ChooseOrder(vet);

        Console.WriteLine("Vetor antes da ordenação:");
        PrintSolutionStatic.ArraySameLine(vet);
        ManagerFileSorting.Order(algorithm, vet);

        Console.WriteLine("\nVetor depois da ordenação:");
        PrintSolutionStatic.ArraySameLine(vet);
        Console.WriteLine(" ");
    }
    #endregion

    #region DataStructrue
    private static Structure.enums.DataStructure ChooseStructure(bool isDynamic = false)
    {
        Console.WriteLine("Escolha a estrutura de dados que será executada");
        Console.WriteLine("A - Pilha");
        Console.WriteLine("B - Fila");
        Console.WriteLine("C - Lista");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));
        Structure.enums.DataStructure structure = global::Structure.enums.DataStructure.PILE;

        Console.WriteLine(" ");
        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: Estrutura de dados 'Pilha' escolhida.");
                if (isDynamic == false) { structure = global::Structure.enums.DataStructure.PILE; }
                else { structure = global::Structure.enums.DataStructure.DYNAMIC_PILE; }
                break;
            case 'B':
                Console.WriteLine("Opção B: Estrutura de dados 'Fila' escolhida.");
                if (isDynamic == false) { structure = global::Structure.enums.DataStructure.QUEUE; }
                else { structure = global::Structure.enums.DataStructure.DYNAMIC_QUEUE; }
                break;
            case 'C':
                Console.WriteLine("Opção C: Estrutura de dados 'Lista' escolhida.");
                if (isDynamic == false) { structure = global::Structure.enums.DataStructure.LIST; }
                else { structure = global::Structure.enums.DataStructure.DYNAMIC_LIST; }
                break;
        }

        Console.WriteLine(" "); return structure;
    }

    private static bool StaticOrDynamic()
    {
        char op = 'C';
        do
        {
            Console.WriteLine("Selecione o tipo de estrutura de dados desejado");
            Console.WriteLine("A - Estática");
            Console.WriteLine("B - Dinâmica");
            op = char.ToUpper(char.Parse(Console.ReadLine()));

            Console.WriteLine(" ");
        } while (op != 'A' && op != 'B');

        if (op == 'B') { Console.WriteLine("Opção B: 'Dinâmica' escolhida.\n"); return true; }
        Console.WriteLine("Opção A: 'Estática' escolhida.\n"); return false;
    }

    private static void Manipulate() // melhorar nome :3
    {
        Structure.enums.DataStructure structure = ChooseStructure(StaticOrDynamic());
        int[] vet = ChooseFile();
        ManagerDataStructure.Manipulate(structure, vet);
    }
    #endregion

    public static void Options()
    {
        Console.WriteLine("Escolha o algoritmo que será executado");
        Console.WriteLine("A - Ordenação interna de dados");
        Console.WriteLine("B - Pilha, fila ou lista");
        Console.WriteLine("C - Ordenação de lista estática com Quick Sort");
        Console.WriteLine("D - Ordenação de lista dinâmica com Quick Sort");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));
        Console.WriteLine(" ");

        switch (op)
        {
            case 'A': Console.WriteLine("Opção A: 'Ordenação interna de dados' escolhida.\n"); Sorting(); break;
            case 'B': Console.WriteLine("Opção B: 'Pilha, fila ou lista' escolhida.\n"); Manipulate(); break;
            case 'C': Console.WriteLine("Opção C: 'Ordenação de lista estática com Quick Sort' escolhida.\n"); StaticListWithSorting(); break;
            case 'D': Console.WriteLine("Opção D: 'Ordenação de lista dinâmica com Quick Sort' escolhida.\n"); DynamicListWithSorting(); break;
        }
        Console.WriteLine(" ");
    }

    private static void StaticListWithSorting()
    {
        // int[] vet = new int[10];
        // vet = ManagerFileReader.File10();
        int[] vet = new int[1000000];
        vet = ManagerFileReader.File1000000();

        List list = new List(vet.Length);

        for (int i = 0; i < vet.Length; i++) { list.Insert(vet[i], Position.END); }
        list.Print();
        Console.WriteLine(" ");

        QuickSortStatic quickSort = new QuickSortStatic();
        quickSort.Sorting(list);

        Console.WriteLine(" ");
        list.Print();
    }

    private static void DynamicListWithSorting()
    {
        int[] vet = new int[1000000];
        vet = ManagerFileReader.File1000000();

        DynamicList list = new DynamicList();

        for (int i = 0; i < vet.Length; i++) { list.Insert(vet[i], Position.END); }
        list.Print();
        Console.WriteLine(" ");

        QuickSortDynamic quickSort = new QuickSortDynamic();
        int[] ordered = quickSort.Sorting(list);

        Console.WriteLine(" ");
        list.Print();
    }
}