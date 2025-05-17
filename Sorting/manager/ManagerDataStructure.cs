using Sorting.basic_class.@static;
using Sorting.enums;
using Structure.enums;
class ManagerDataStructure
{
    public static void Manipulate(DataStructure structure, int[] vet)
    {
        int size, op = 1;
        size = ChooseSize();

        switch (structure)
        {
            case DataStructure.PILE:
                Pile p = new Pile(vet.Length + size);

                for (int i = 0; i < vet.Length; i++) { p.Insert(vet[i]); }
                p.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulatePile(p);
                    Console.WriteLine(" ");
                } while (op != 0);
                break;

            case DataStructure.QUEUE:
                Queue q = new Queue(vet.Length + size);

                Console.WriteLine(" ");
                for (int i = 0; i < vet.Length; i++) { q.Insert(vet[i]); }
                q.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateQueue(q);
                } while (op != 0);
                break;

            case DataStructure.LIST:
                List l = new List(vet.Length + size);

                for (int i = 0; i < vet.Length; i++) { l.Insert(vet[i], Position.End); }
                l.Print();
                Console.WriteLine(" ");

                do
                {
                    op = ManipulateList(l);
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

    private static int ManipulatePile(Pile p)
    {
        Console.WriteLine("Selecione a opção que será executada");
        Console.WriteLine("A - Inserir novo elemento na pilha");
        Console.WriteLine("B - Remover elemento da pilha");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (op)
        {
            case 'A':
                Console.WriteLine("\nOpção A: 'Inserir novo elemento na pilha' escolhida.\n");
                int v = InputElement();
                p.Insert(v);
                p.Print();
                break;

            case 'B':
                Console.WriteLine("\nOpção B: 'Remover elemento da pilha' escolhida.\n");
                p.Remove();
                p.Print();
                break;
        }
        Console.WriteLine("\nInsira o número '1' se deseja continuar manipulando essa estrutura.\nCaso contrário, digite qualquer outro número inteiro.");
        int o = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return o;
    }

    private static int ManipulateQueue(Queue q)
    {
        Console.WriteLine("Selecione a opção que será executada");
        Console.WriteLine("A - Inserir novo elemento na fila");
        Console.WriteLine("B - Remover elemento da fila");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na fila' escolhida.\n");
                int v = InputElement();
                q.Insert(v);
                q.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da fila' escolhida.\n");
                q.Remove();
                q.Print();
                break;
        }
        Console.WriteLine("\nInsira o número '1' se deseja continuar manipulando essa estrutura.\nCaso contrário, digite qualquer outro número inteiro.");
        int o = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return o;
    }

    private static int ManipulateList(List l)
    {
        Console.WriteLine("Selecione a opção que será executada");
        Console.WriteLine("A - Inserir novo elemento na lista");
        Console.WriteLine("B - Remover elemento da lista");
        char op = char.ToUpper(char.Parse(Console.ReadLine()));

        Position a = Position.End;
        int p, v;

        switch (op)
        {
            case 'A':
                Console.WriteLine("Opção A: 'Inserir novo elemento na lista' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.Custom) { p = CustomPosition(l.cont - 1); } else { p = 0; }
                v = InputElement();

                l.Insert(v, a, p);
                l.Print();
                break;

            case 'B':
                Console.WriteLine("Opção B: 'Remover elemento da lista' escolhida.\n");
                a = ChooseListPosition();
                if (a == Position.Custom) { p = CustomPosition(l.cont - 1); } else { p = 0; }
                v = InputElement();

                l.Remove(v, a, p);
                l.Print();
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
            case 'A': Console.WriteLine("Opção A: 'Início' escolhida.\n"); return Position.Start;
            case 'B': Console.WriteLine("Opção B: 'Customizada' escolhida.\n"); return Position.Custom;
            case 'C': Console.WriteLine("Opção C: 'Final' escolhida.\n"); return Position.End;
        }

        return Position.End;
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
        Console.WriteLine("Insira o valor do elementos que deseja inserir.");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");
        return value;
    }

}