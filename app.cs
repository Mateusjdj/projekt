using System;

class BubbleSort
{
    private int[] array;

    public BubbleSort(int[] arr)
    {
        array = arr;
    }

    private void Swap(int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private void Sort()
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(j, j + 1);
                }
            }
        }
    }

    public void Display()
    {
        Sort();
        Console.Write("Sorted array: ");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // tescik
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        int[] arr2 = { 11, 12, 22, 25, 34, 64, 90 };
        int[] arr3 = { 90, 64, 34, 25, 22, 12, 11 };

        BubbleSort bs1 = new BubbleSort(arr1);
        bs1.Display();

        BubbleSort bs2 = new BubbleSort(arr2);
        bs2.Display();

        BubbleSort bs3 = new BubbleSort(arr3);
        bs3.Display();
    }
}
