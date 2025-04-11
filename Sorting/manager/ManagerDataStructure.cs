using Sorting.enums;
using Sorting.sorting.simple;

class ManagerDataStructure
{
    public static void Order(Sortings algorithm, int[] vet)
    {
        int[] ordered;

        switch (algorithm)
        {
            case Sortings.BUBBLESORT:
                BubbleSort b = new BubbleSort();
                ordered = b.Sorting(vet);
                break;
        }
    }
}
