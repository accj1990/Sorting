using Sorting.manager;
using Sorting.print;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        int op = 0;
        do
        {
            Console.WriteLine("Insira a opção desejada");
            Console.WriteLine("0 - Encerrar programa");
            Console.WriteLine("1 - Continuar programa");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (op == 1) { Menu(); }

        } while (op != 0);
    }

    private static int[] ChooseFile()
    {
        Console.WriteLine("Escolha o arquivo que será lido");
        Console.WriteLine("A - 1000000-aleatorios");
        Console.WriteLine("B - 100000-aleatorios");
        Console.WriteLine("C - 10000-aleatorios");
        Console.WriteLine("D - 1000-aleatorios");
        Console.WriteLine("E - 100-aleatorios");
        Console.WriteLine("F - 10-aleatorios");
        char op = char.Parse(Console.ReadLine());
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
    private static Sorting.enums.Sortings ChooseAlgorithm(int[] vet)
    {
        Console.WriteLine("Escolha o algoritmo que será executado");
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
        char op = char.Parse(Console.ReadLine());
        Sorting.enums.Sortings algorithm = Sorting.enums.Sortings.BUBBLESORT;

        Console.WriteLine(" ");
        switch (op)
        {
            case 'A': Console.WriteLine("Opção A: Algoritmo 'Bubble Sort' escolhido."); algorithm = Sorting.enums.Sortings.BUBBLESORT; break;
            case 'B': Console.WriteLine("Opção B: Algoritmo 'Selection Sort' escolhido."); algorithm = Sorting.enums.Sortings.SELECTIONSORT; break;
            case 'C': Console.WriteLine("Opção C: Algoritmo 'Insertion Sort' escolhido."); algorithm = Sorting.enums.Sortings.INSERTIONSORT; break;
            case 'D': Console.WriteLine("Opção D: Algoritmo 'Bucket Sort' escolhido."); algorithm = Sorting.enums.Sortings.BUCKETSORT; break;
            case 'E': Console.WriteLine("Opção E: Algoritmo 'Counting Sort' escolhido."); algorithm = Sorting.enums.Sortings.COUNTINGSORT; break;
            case 'F': Console.WriteLine("Opção F: Algoritmo 'Radix Sort' escolhido."); algorithm = Sorting.enums.Sortings.RADIXSORT; break;
            case 'G': Console.WriteLine("Opção G: Algoritmo 'Shell Sort' escolhido."); algorithm = Sorting.enums.Sortings.SHELLSORT; break;
            case 'H': Console.WriteLine("Opção H: Algoritmo 'Quick Sort' escolhido."); algorithm = Sorting.enums.Sortings.QUICKSORT; break;
            case 'I': Console.WriteLine("Opção I: Algoritmo 'Merge Sort' escolhido."); algorithm = Sorting.enums.Sortings.MERGESORT; break;
            case 'J': Console.WriteLine("Opção J: Algoritmo 'Heap Sort' escolhido."); algorithm = Sorting.enums.Sortings.HEAPSORT; break;
        }
        Console.WriteLine(" "); return algorithm;
    }

    private static void Menu() // solicitando ao usuario algoritmo e arquivo desejados
    {
        int[] vet = ChooseFile();
        Sorting.enums.Sortings algorithm = ChooseAlgorithm(vet);

        Console.WriteLine("Vetor antes da ordenação:");
        PrintSolutionStatic.ArraySameLine(vet, Sorting.enums.Sortings.BUBBLESORT);
        ManagerFileSorting.Order(algorithm, vet);

        Console.WriteLine("\nVetor depois da ordenação:");
        PrintSolutionStatic.ArraySameLine(vet, Sorting.enums.Sortings.BUBBLESORT);
        Console.WriteLine(" ");
    }
}