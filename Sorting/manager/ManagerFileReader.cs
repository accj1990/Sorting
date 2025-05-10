using Sorting.reader;
using Sorting.utils;

namespace Sorting.manager
{
    class ManagerFileReader
    {
        static ReaderFile reader = new ReaderFile();

        public static int[] File10()
        {
            ReaderFile reader = new ReaderFile("./inputs/10-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] File100()
        {
            ReaderFile reader = new ReaderFile("./inputs/100-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] File1000()
        {
            ReaderFile reader = new ReaderFile("./inputs/1000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] File10000()
        {
            ReaderFile reader = new ReaderFile("./inputs/10000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] File100000()
        {
            ReaderFile reader = new ReaderFile("./inputs/100000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] File1000000()
        {
            ReaderFile reader = new ReaderFile("./inputs/1000000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }
    }
}
