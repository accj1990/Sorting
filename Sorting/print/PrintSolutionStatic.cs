using Sorting.enums;
using Sorting.utils;

namespace Sorting.print
{
    static class PrintSolutionStatic
    {
        public static void ArraySameLine(Sortings algorithm, int[] vet)
        {
            // Console.WriteLine("ALGORITMO - " + UtilEnum.GetDescription(algoritmo) + "\n");
            // Console.WriteLine("INICIO - Imprimindo estrutura em alocação estática sem pular linha.\n");
            // Console.WriteLine("ALGORITMO - " + UtilEnum.GetDescription(algoritmo) + "\n");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.Write("\n");
            // Console.WriteLine("\nFIM - Imprimindo estrutura em alocação estática sem pular linha.\n");
        }

        public static void ArrayEachLine(int[] vet)
        {
            // Console.WriteLine("INICIO - Imprimindo estrutura em alocação estática com quebra de linha. \n");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.Write("\n");

            // Console.WriteLine("\nFIM - Imprimindo estrutura em alocação estática com quebra de linha.");
        }
    }
}
