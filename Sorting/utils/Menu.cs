using Sorting.enums;
using Sorting.manager;

namespace Sorting.utils
{
    class Menu
    {
        public static void Init()
        {
            string algorythm = "";
            string file = "";

            Console.Clear();
            Console.WriteLine("Digite o nome do algorítmo que será utilizado (ou sair para sair)");

            foreach (Sortings sortingMethod in Enum.GetValues(typeof(Sortings)))
            {
                Console.WriteLine(sortingMethod);
            }

            algorythm = Console.ReadLine();
            Console.Clear();

            if (algorythm.ToLower() == "sair") return;

            Console.WriteLine("Digite o nome do arquivo que será lido (ou sair para sair)");

            file = Console.ReadLine();
            Console.Clear();

            if (file.ToLower() == "sair") return;

            ExecuteSorting(algorythm, file);
        }

        public static void ExecuteSorting(string algorythm, string file)
        {
            Console.Clear();

            Sortings selectedAlgorythm = Sortings.BUBBLESORT;
            bool selectedValidAlgorythm = false;

            int[] arrayToBeSorted = [0];

            foreach (Sortings sortingMethod in Enum.GetValues(typeof(Sortings)))
            {
                if (sortingMethod.ToString() == algorythm.ToUpper())
                {
                    selectedAlgorythm = sortingMethod;
                    selectedValidAlgorythm = true;
                }


            }

            if (selectedValidAlgorythm == false)
            {
                Console.WriteLine($"O algorítimo {algorythm} é inválido, verifique o a disponibilidade do algorítimo.");
                Console.ReadKey();

                Init();
            }

            if (arrayToBeSorted == ManagerFileReader.ReadArchive(file))
            {
                Console.WriteLine($"O arquivo {file} não foi encontrado, verifique o a disponibilidade do arquivo.");
                Console.ReadKey();

                Init();
            }

            arrayToBeSorted = ManagerFileReader.ReadArchive(file);

            int[] sortedArray = ManagerFileSorting.Ordenar(selectedAlgorythm, arrayToBeSorted);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

            Console.ReadKey();

            Init();
        }
    }
}