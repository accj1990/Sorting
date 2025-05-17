using Sorting.basic_class.dynamic;
using Sorting.basic_class.@static;
using Sorting.enums;
using Structure.enums;
class ManagerDataStructure
{
    static Pile pile = null;
    static DynamicPile dynamicPile = null;

    static Queue queue;
    static DynamicQueue dynamicQueue = null;

    static List list = null;
    static DynamicList dynamicList = null;

    public static void Manipulate(DataStructure structure, int[] vet)
    {
        int size, op = 1;
        size = ChooseSize();

        switch (structure)
        {
            case DataStructure.PILE:
                Pile p = new Pile(vet.Length + size);
                pile = p;

                for (int i = 0; i < vet.Length; i++) { p.Insert(vet[i]); }
                p.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateStructure(DataStructure.PILE);
                    Console.WriteLine(" ");
                } while (op != 0);
                break;

            case DataStructure.QUEUE:
                Queue q = new Queue(vet.Length + size);
                queue = q;

                Console.WriteLine(" ");
                for (int i = 0; i < vet.Length; i++) { q.Insert(vet[i]); }
                q.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateStructure(DataStructure.QUEUE);
                } while (op != 0);
                break;

            case DataStructure.LIST:
                List l = new List(vet.Length + size);
                list = l;

                for (int i = 0; i < vet.Length; i++) { l.Insert(vet[i], Position.END); }
                l.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateStructure(DataStructure.LIST);
                    Console.WriteLine(" ");
                } while (op != 0);
                break;

            case DataStructure.DYNAMIC_PILE:
                break;

            case DataStructure.DYNAMIC_QUEUE:
                break;

            case DataStructure.DYNAMIC_LIST:
                DynamicList dl = new DynamicList();
                dynamicList = dl;

                for (int i = 0; i < vet.Length; i++) { dl.Insert(vet[i], Position.END); }
                dl.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateStructure(DataStructure.DYNAMIC_LIST);
                    Console.WriteLine(" ");
                } while (op != 0);
                break;
        }
    }

    private static int ChooseSize()
    {
        Console.WriteLine("Insira o número de elementos extras que essa estrutura de dados deve conter");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        return size;
    }

    #region Static
    private static void ManipulatePile(int op)
    {
        switch (op)
        {
            case 'A':
                Console.WriteLine("\nOpção A: 'Inserir novo elemento na pilha' escolhida.\n");
                int v = InputElement();
                pile.Insert(v);
                pile.Print();
                break;

            case 'B':
                Console.WriteLine("\nOpção B: 'Remover elemento da pilha' escolhida.\n");
                pile.Remove();
                pile.Print();
                break;
        }
    }

    private static void ManipulateQueue(int op)
    {
        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na fila' escolhida.\n");
                int v = InputElement();
                queue.Insert(v);
                queue.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da fila' escolhida.\n");
                queue.Remove();
                queue.Print();
                break;
        }
    }

    private static void ManipulateList(int op)
    {
        Position a = Position.END;
        int p, v;

        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na lista' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.CUSTOM) { p = CustomPosition(list.cont - 1); } else { p = 0; }
                v = InputElement();

                list.Insert(v, a, p);
                list.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da lista' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.CUSTOM) { p = CustomPosition(list.cont - 1); } else { p = 0; }

                list.Remove(a, p);
                list.Print();
                break;
        }
    }
    #endregion

    #region Dynamic

    private static void ManipulateDynamicPile(int op)
    {
        switch (op)
        {
            case 'A':
                Console.WriteLine("\nOpção A: 'Inserir novo elemento na pilha dinâmica' escolhida.\n");
                int v = InputElement();
                dynamicPile.Insert(v);
                dynamicPile.Print();
                break;

            case 'B':
                Console.WriteLine("\nOpção B: 'Remover elemento da pilha dinâmica' escolhida.\n");
                dynamicPile.Remove();
                dynamicPile.Print();
                break;
        }
    }

    private static void ManipulateDynamicQueue(int op)
    {
        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na fila dinâmica' escolhida.\n");
                int v = InputElement();
                dynamicQueue.Insert(v);
                dynamicQueue.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da fila dinâmica' escolhida.\n");
                dynamicQueue.Remove();
                dynamicQueue.Print();
                break;
        }
    }

    private static void ManipulateDynamicList(int op)
    {
        Position a = Position.END;
        int p, v;

        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na lista dinâmica' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.CUSTOM) { p = CustomPosition(dynamicList.cont - 1); } else { p = 0; }
                v = InputElement();

                dynamicList.Insert(v, a, p);
                dynamicList.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da lista dinâmica' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.CUSTOM) { p = CustomPosition(list.cont - 1); } else { p = 0; }

                dynamicList.Remove(a, p);
                dynamicList.Print();
                break;
        }
    }

    #endregion

    private static int ManipulateStructure(DataStructure structure)
    {
        Console.WriteLine("Selecione a opção que será executada");
        Console.WriteLine("A - Inserir novo elemento");
        Console.WriteLine("B - Remover elemento");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (structure)
        {
            case DataStructure.PILE:
                ManipulatePile(op);
                break;
            case DataStructure.DYNAMIC_PILE:
                ManipulateDynamicPile(op);
                break;
                break;
            case DataStructure.QUEUE:
                ManipulateQueue(op);
                break;
            case DataStructure.DYNAMIC_QUEUE:
                ManipulateDynamicQueue(op);
                break;
            case DataStructure.LIST:
                ManipulateList(op);
                break;
            case DataStructure.DYNAMIC_LIST:
                ManipulateDynamicList(op);
                break;
        }
        Console.WriteLine("\nInsira o número '1' se deseja continuar manipulando essa estrutura.\nCaso contrário, digite qualquer outro número inteiro.");
        int o = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        return o;
    }

    private static Position ChooseListPosition()
    {
        Console.WriteLine("Escolha a posição que será manipulada");
        Console.WriteLine("A - Início");
        Console.WriteLine("B - Customizada");
        Console.WriteLine("C - Final");

        char op = char.ToUpper(char.Parse(Console.ReadLine()));
        Console.WriteLine(" ");

        switch (op)
        {
            case 'A': Console.WriteLine("Opção A: 'Início' escolhida.\n"); return Position.START;
            case 'B': Console.WriteLine("Opção B: 'Customizada' escolhida.\n"); return Position.CUSTOM;
            case 'C': Console.WriteLine("Opção C: 'Final' escolhida.\n"); return Position.END;
        }

        return Position.END;
    }

    private static int CustomPosition(int max)
    {
        Console.WriteLine($"Insira a posição (entre 0 e {max}) que será manipulada");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        return position;
    }

    private static int InputElement()
    {
        Console.WriteLine("Insira o valor do novo elemento");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        return value;
    }

}