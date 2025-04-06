using Sorting.manager;

namespace Sorting
{
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

        private static Sorting.enums.Sortings ChooseAlgorithm(int[] vet)
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
            Sorting.enums.Sortings algorithm = global::Sorting.enums.Sortings.BUBBLESORT;

            Console.WriteLine(" ");
            switch (op)
            {
                case 'A': Console.WriteLine("Opção A: Ordenação 'Bubble Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.BUBBLESORT; break;
                case 'B': Console.WriteLine("Opção B: Ordenação 'Selection Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.SELECTIONSORT; break;
                case 'C': Console.WriteLine("Opção C: Ordenação 'Insertion Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.INSERTIONSORT; break;
                case 'D': Console.WriteLine("Opção D: Ordenação 'Bucket Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.BUCKETSORT; break;
                case 'E': Console.WriteLine("Opção E: Ordenação 'Counting Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.COUNTINGSORT; break;
                case 'F': Console.WriteLine("Opção F: Ordenação 'Radix Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.RADIXSORT; break;
                case 'G': Console.WriteLine("Opção G: Ordenação 'Shell Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.SHELLSORT; break;
                case 'H': Console.WriteLine("Opção H: Ordenação 'Quick Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.QUICKSORT; break;
                case 'I': Console.WriteLine("Opção I: Ordenação 'Merge Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.MERGESORT; break;
                case 'J': Console.WriteLine("Opção J: Ordenação 'Heap Sort' escolhida."); algorithm = global::Sorting.enums.Sortings.HEAPSORT; break;
            }
            Console.WriteLine(" "); return algorithm;
        }

        private static void Sorting() // solicitando ao usuario algoritmo e arquivo desejados
        {
            int[] vet = ChooseFile();
            Sorting.enums.Sortings algorithm = ChooseAlgorithm(vet);

            /* Console.WriteLine("Vetor antes da ordenação:");
              PrintSolutionStatic.ArraySameLine(algorithm, vet); */
            ManagerFileSorting.Order(algorithm, vet);

            /* Console.WriteLine("\nVetor depois da ordenação:");
            PrintSolutionStatic.ArraySameLine(algorithm, vet); */
            Console.WriteLine(" ");
        }

        public static void Options()
        {
            Console.WriteLine("Escolha o algoritmo que será executado");
            Console.WriteLine("A - Ordenação interna de dados");
            Console.WriteLine("B - Pilha e fila");
            char op = char.ToUpper(char.Parse(Console.ReadLine()));
            Console.WriteLine(" ");

            switch (op)
            {
                case 'A': Console.WriteLine("Opção A: 'Ordenação interna de dados' escolhida.\n"); Sorting(); break;
                case 'B': Console.WriteLine("Opção B: 'Pilha e fila' escolhida.\n"); break;
            }
            Console.WriteLine(" ");
        }
    }
}
